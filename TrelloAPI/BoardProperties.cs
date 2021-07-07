using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloAPI
{
    public class BoardProperties
    {
        public string id { get; set; }
        public string name { get; set; }

        public List<BoardProperties> GetBoardsFromJSON(string response)
        {
            dynamic dynJson = JsonConvert.DeserializeObject(response);
            var boardsList = new List<BoardProperties>();

            foreach (var item in dynJson)
            {
                boardsList.Add(new BoardProperties { id = item.id, name = item.name });
            }
            return boardsList;
        }
    }
}
