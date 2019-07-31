using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim_Algorithm
{
    class Vertex
    {
        const int INFINITY = 9999999;
        int id;
        int key;
        Vertex pred;
        bool visited;

        public Vertex(int id)
        {
            this.Id = id;
            pred = null;
            Key = INFINITY;
            visited = false;
        }

        public List<Edge> adj = new List<Edge>();

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        internal Vertex Pred
        {
            get
            {
                return pred;
            }

            set
            {
                pred = value;
            }
        }

        public int Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public bool Visited
        {
            get
            {
                return visited;
            }

            set
            {
                visited = value;
            }
        }

        public string adjline()
        {
            string pp = pred == null ? "-" : pred.id.ToString();
            string s = string.Format("{0}:{1}:{2}", this.id, pp, key);
            foreach (Edge edge in adj)
            {
                s += " " + edge.Dst.id;
            }
            return s;
        }

    }
}
