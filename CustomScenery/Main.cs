using UnityEngine;

namespace Custom_Scenery
{
    public class Main : IMod
    {
        private GameObject _go;
        string name = "HPregistar";
        string description = "Bla Bla Bla";
        public void onEnabled()
        {
            
        }

        public void onDisabled()
        {
          //  _go.GetComponent<Loader>().UnloadScenery();
          
        }

        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public string Path { get; set; }
        public string Identifier { get; set; }
    }
}
