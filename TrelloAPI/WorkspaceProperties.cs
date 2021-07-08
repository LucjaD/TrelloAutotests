using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloAPI
{
    public class WorkspaceProperties
    {
        public string name { get; set; }
        public string displayName { get; set; }

        public List<WorkspaceProperties> GetWorkspacesFromJSON(string response)
        {
            dynamic dynJson = JsonConvert.DeserializeObject(response);
            var workspacesList = new List<WorkspaceProperties>();

            foreach (var item in dynJson)
            {
                workspacesList.Add(new WorkspaceProperties { name = item.name, displayName = item.displayName });
            }
            return workspacesList;
        }
    }
}
