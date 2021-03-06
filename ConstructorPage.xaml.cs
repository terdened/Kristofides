﻿using Kristofides.GraphStructure;
using Kristofides.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kristofides
{
    /// <summary>
    /// Interaction logic for ConstructorPage.xaml
    /// </summary>
    public partial class ConstructorPage : Page
    {
        String state = "";
        Research.Research _research;
        int pointId = 0;
        Vertex selected=null;
        List<EdgeView> edgeViewList;
        List<VertexView> vertexViewList;
        List<Graph> history;
        int currentGraph = 0;

        private void UpdateGraph()
        {
            if (currentGraph != history.Count - 1)
            {
                history.RemoveAt(currentGraph + 1);      
            }

            history.Add(new Graph(_research.getGraph()));
            currentGraph++;
            ShowGraph();
        }

        private void PrewGraph()
        {
            if (currentGraph > 0)
            {
                currentGraph--;
                _research.generateGraph(new Graph(history[currentGraph]));
                pointId = _research.getGraph().getlastVertexId()+1;
                ShowGraph();
            }else
            {
                MessageBox.Show("It is the Begining");
            }
        }

        private void NextGraph()
        {
            if (currentGraph < history.Count-1)
            {
                currentGraph++;
                _research.generateGraph(history[currentGraph]);
                pointId = _research.getGraph().getlastVertexId()+1;
                ShowGraph();
            }
            else
            {
                MessageBox.Show("It is the End");
            }
        }

        public ConstructorPage(Research.Research research)
        {

            InitializeComponent();

            history = new List<Graph>();
            vertexViewList = new List<VertexView>();
            edgeViewList = new List<EdgeView>();
            InitCanvas();
            _research = research;
            if (_research != null)
            {
                if(_research.getGraph() != null)
                {
                    ShowGraph();
                    pointId = research.getGraph()._vertexList.Count;
                }
                else
                {
                    _research.initGraph();
                }
            }
            else
            {
                _research = new Research.Research();
            }
            history.Add(new Graph(_research.getGraph()));
        }

        private void RefreshCanvas()
        {
            foreach (VertexView vertex in vertexViewList)
            {
                try
                {
                    GraphCanvas.Children.Remove(vertex.circle);
                    GraphCanvas.Children.Remove(vertex.text);
                }
                catch
                {

                }
            }

            foreach (EdgeView edge in edgeViewList)
            {
                try
                {
                    GraphCanvas.Children.Remove(edge.line);
                    GraphCanvas.Children.Remove(edge.text);
                    GraphCanvas.Children.Remove(edge.title);
                }
                catch
                {

                }
            }
        }

        private void InitCanvas()
        {
            GraphCanvas.Children.Clear();
            Rectangle back = new Rectangle();
            back.Width = 700;
            back.Height = 500;
            back.Fill = System.Windows.Media.Brushes.White;
            back.Stroke = System.Windows.Media.Brushes.Gray;

            GraphCanvas.Background = new SolidColorBrush(Colors.White);
        }

        private void CreatePointButton_Click(object sender, RoutedEventArgs e)
        {
            state = "CreatePoint";
            CreatePointButton.BorderBrush = System.Windows.Media.Brushes.Green;
            CreateLineButton.BorderBrush = System.Windows.Media.Brushes.Black;
            CreatePointButton.BorderThickness = new Thickness(5);
            CreateLineButton.BorderThickness = new Thickness(1);
        }

        private void CreateLineButton_Click(object sender, RoutedEventArgs e)
        {
            state = "CreateLine";
            CreateLineButton.BorderBrush = System.Windows.Media.Brushes.Green;
            CreatePointButton.BorderBrush = System.Windows.Media.Brushes.Black;
            CreateLineButton.BorderThickness = new Thickness(5);
            CreatePointButton.BorderThickness = new Thickness(1);
        }

        private bool IsSelect(Point p1, Point p2)
        {
            Vector vector= new Vector(p1.X-p2.X, p1.Y-p2.Y);

            if (vector.Length > 10)
                return false;
            else
                return true;
        }

        private Vertex SelectVertex(Point p)
        {
            Vertex result = null;

            foreach(var vertex in _research.getGraph()._vertexList)
            {
                if(IsSelect(p, new Point(vertex._x+4,vertex._y+44)))
                {
                    return vertex;
                }
            }

            return result;
        }

        private void Canvas_Click(object sender, MouseButtonEventArgs e)
        {
            if (state == "CreatePoint")
            {
                Point p = e.GetPosition(this);
                GraphStructure.Vertex vetex = new GraphStructure.Vertex();
                if (IsVertexTitled.IsChecked == true)
                vetex._title = Microsoft.VisualBasic.Interaction.InputBox("Input vertex title", "Input", "", 100, 100);
                vetex._x = p.X-4;
                vetex._y = p.Y - 44;
                vetex._id = pointId++;
                _research.getGraph().addVertex(vetex);
                UpdateGraph();
            }
            else
            if (state == "CreateLine")
            {
                Point p = e.GetPosition(this);

                if(selected==null)
                {
                    selected = SelectVertex(p);
                    ShowGraph();
                }
                else
                {
                    if (SelectVertex(p)!=null)
                    {
                        if (selected._id != SelectVertex(p)._id)
                        {
                            Edge edge = new Edge(selected, SelectVertex(p));
                            if (IsEdgeTitled.IsChecked == true)
                                edge._title = Microsoft.VisualBasic.Interaction.InputBox("Input edge title", "Input", "", 100, 100);

                            _research.getGraph().addEdge(edge);
                            selected = null;
                            UpdateGraph();
                        }else
                        {
                            selected = null;
                            ShowGraph();
                        }
                    }
                }
            }
        }

        private void Open_Image(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dl1 = new Microsoft.Win32.OpenFileDialog();
            dl1.FileName = "MYFileSave";
            dl1.DefaultExt = ".png";
            dl1.Filter = "Image documents (.png)|*.png";
            Nullable<bool> result = dl1.ShowDialog();

            if (result == true)
            {
                string filename = dl1.FileName;
                ImageBrush brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(@filename, UriKind.Relative));
                GraphCanvas.Background = brush;
            }
        }

        public void ShowGraph()
        {
            RefreshCanvas();
            edgeViewList = new List<EdgeView>();
            List<Edge> edgeList = _research.getGraph().getEdgeList();

            for (int i = 0; i < edgeList.Count; i++)
            {
                edgeViewList.Add(new EdgeView(edgeList[i]._a._x, edgeList[i]._a._y, edgeList[i]._b._x, edgeList[i]._b._y, (int)edgeList[i]._length, edgeList[i]._title));
                this.GraphCanvas.Children.Add(edgeViewList.Last().line);
                this.GraphCanvas.Children.Add(edgeViewList.Last().text);
                if(edgeViewList.Last().title!=null)
                    this.GraphCanvas.Children.Add(edgeViewList.Last().title);
            }

            vertexViewList = new List<VertexView>();
            List<Vertex> vertexList = _research.getGraph().getVertexList();

            for (int i = 0; i < vertexList.Count; i++)
            {
                if (selected != null)
                {
                    if (vertexList[i]._id != selected._id)
                        vertexViewList.Add(new VertexView(vertexList[i]._x, vertexList[i]._y, vertexList[i]._id, vertexList[i]._title));
                    else
                        vertexViewList.Add(new SelectedVertexView(vertexList[i]._x, vertexList[i]._y, vertexList[i]._id, vertexList[i]._title));
                }
                else
                {
                    vertexViewList.Add(new VertexView(vertexList[i]._x, vertexList[i]._y, vertexList[i]._id, vertexList[i]._title));
                }

                if (vertexViewList.Last().title != null)
                    this.GraphCanvas.Children.Add(vertexViewList.Last().title);
                this.GraphCanvas.Children.Add(vertexViewList.Last().circle);
                this.GraphCanvas.Children.Add(vertexViewList.Last().text);
            }
        }

        private void Strong_Linked(object sender, RoutedEventArgs e)
        {
            var vertexList = _research.getGraph()._vertexList;
            _research.getGraph()._edgeList.Clear();
            foreach(Vertex vertex in vertexList)
            {
                for (int i = vertex._id+1; i < vertexList.Count; i++)
                {
                    Edge edge = new Edge(vertex, vertexList[i]);
                    _research.getGraph().addEdge(edge);
                }
            }
            UpdateGraph();
        }

        private void PrewGraphButton_Click(object sender, RoutedEventArgs e)
        {
            PrewGraph();
        }

        private void NextGraphButton_Click(object sender, RoutedEventArgs e)
        {
            NextGraph();
        }
    }
}
