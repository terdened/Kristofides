﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kristofides.GraphStructure
{
    public class Graph
    {
        public List<Vertex> _vertexList;
        public List<Edge> _edgeList;
        private int _vertexCount;
        private int _minEdge;
        private int _maxEdge;


        public Graph(int vertexCount, int minEdge, int maxEdge)
        {
            _vertexCount = vertexCount;
            _minEdge = minEdge;
            _maxEdge = maxEdge;
            _vertexList = new List<Vertex>();
            _edgeList = new List<Edge>();
        }

        public Graph()
        {
            _vertexList = new List<Vertex>();
            _edgeList = new List<Edge>();
        }

        public Graph(Graph graph)
        {
            _vertexCount = graph._vertexCount;
            _minEdge = graph._minEdge;
            _maxEdge = graph._maxEdge;
            _vertexList = new List<Vertex>();
            _edgeList = new List<Edge>();

            foreach (Vertex vertex in graph._vertexList)
            {
                _vertexList.Add(new Vertex(vertex));
            }

            foreach (Edge edge in graph._edgeList)
            {
                _edgeList.Add(new Edge(edge));
            }
        }

        public List<Vertex> getVertexList()
        {
            return _vertexList;
        }

        public List<Edge> getEdgeList()
        {
            return _edgeList;
        }

        public double[][] getMatrix()
        {
            double[][] result = new double[_vertexList.Count][];

            for (int i = 0; i < _vertexList.Count; i++)
            {
                result[i]=new double[_vertexList.Count];
                for (int j = 0; j < _vertexList.Count; j++)
                {
                    result[i][j] = _vertexList[i].GetLengthToVertexById(_vertexList[j]._id);
                }
            }

            return result;
        }

        public Vertex getVertexById(int id)
        {
            Vertex result = null;

            for (int i = 0; i < _vertexList.Count; i++)
            {
                if (_vertexList[i]._id == id)
                    result = _vertexList[i];
            }

            return result;
        }

        public int getVertexIndexById(int id)
        {
            int result = -1;

            for (int i = 0; i < _vertexCount; i++)
            {
                if (_vertexList[i]._id == id)
                    result = i;
            }

            return result;
        }

        public List<Vertex> getVertex()
        {
            return _vertexList;
        }

        public List<Edge> getEdges()
        {
            return _edgeList;
        }

        public List<Edge> getEdges(Vertex v)
        {
            foreach (Vertex ver in _vertexList)
            {
                if ((ver._x == v._x) && (ver._y == v._y))
                {
                    return ver._edgeList;
                }
            }

            return null;
        }


        public void addVertex(Vertex v)
        {
            Vertex newVertex = new Vertex(v._id,v._x,v._y);
            newVertex._edgeList = new List<Edge>();
            _vertexList.Add(newVertex);
        }

        public void addEdge(Edge edge)
        {
            Vertex a = getVertexById(edge._a._id);
            if (a == null)
            {
                //_vertexList.Add(edge._a);
                addVertex(edge._a);
                a = _vertexList.Last();
            }


            Vertex b = getVertexById(edge._b._id);
            if (b == null)
            {
                //_vertexList.Add(edge._b);
                addVertex(edge._b);
                b = _vertexList.Last();
            }

            Edge newEdge = new Edge(a, b);
            this._edgeList.Add(newEdge);
            a._edgeList.Add(newEdge);
            Edge newEdgeb = new Edge(b, a);
            b._edgeList.Add(newEdgeb);
        }

        public void updateVertex()
        {
            int a = 0;
            foreach (Vertex vertex in _vertexList)
            {
                vertex._edgeList = new List<Edge>();

                foreach(Edge edge in _edgeList)
                {
                    if (edge._a._id == vertex._id)
                    {
                        vertex._edgeList.Add(new Edge(vertex, edge._b));
                    }
                    else
                    if (edge._b._id == vertex._id)
                    {
                        vertex._edgeList.Add(new Edge(vertex, edge._a));
                    }
                }
            }
        }

        public void generateGraph()
        {
            Random rand = new Random();
            for (int i = 0; i < _vertexCount; i++)
            {
                
                double x = rand.NextDouble() * 700;
                double y = rand.NextDouble() * 500;

                _vertexList.Add(new Vertex(i,x,y));
            }

            for (int i = 0; i < _vertexCount; i++)
            {
                int count = (int)(rand.NextDouble() * (_maxEdge - _minEdge)) + _minEdge;

                while (_vertexList[i]._edgeList.Count < count)
                {
                    Boolean isFree = false;
                    int secound = (int)(rand.NextDouble() * _vertexCount);

                    while (!isFree)
                    {
                        bool isRepeat = false;
                        for (int j = 0; j < _vertexList[i]._edgeList.Count; j++)
                        {
                            if (_vertexList[i]._edgeList[j]._b._id == secound)
                                isRepeat = true;
                        }

                        if ((secound != i) && (getEdges(_vertexList[secound]).Count < _maxEdge) && (!isRepeat))
                        {
                            isFree = true;
                        }
                        else
                        {
                            secound = (int)(rand.NextDouble() * _vertexCount);
                        }

                        
                    }

                    _vertexList[i].AddEdge(getVertexById(secound));
                    _vertexList[secound].AddEdge(getVertexById(i));
                    _edgeList.Add(new Edge(_vertexList[i], _vertexList[secound]));
                }
            }
        }
    }
}
