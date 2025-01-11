using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicLibrary;


namespace GraphicObjectManagers
{
    public class GraphicObjectManager
    {
        private const string FILE_NAME = "Shapes.json";

        private List<GraphicShape> graphicShapes = new List<GraphicShape>();

        public List<GraphicShape> GraphicShapes 
        { 
            get 
            {
				return graphicShapes;
			}
            set 
            {
                graphicShapes = value;    
            } 
        }

        public GraphicObjectManager(){}

        public void AddGraphicShape(GraphicShape graphicShape)
        {
            graphicShapes.Add(graphicShape);
        }

        public void RemoveGraphicShape(GraphicShape graphicShape)
        {
            graphicShapes.Remove(graphicShape);
        }

        public void RemoveLastShape()
        {
            graphicShapes.RemoveAt(graphicShapes.Count - 1);
        }

		public void Clear()
		{
			graphicShapes.Clear();
		}

		public void Serialize()
        {
            throw new NotImplementedException();
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}
