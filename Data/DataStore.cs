using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonTest.Data
{
    class ProjectData
    {
        public Models.Leerling LeerlingDetails { get; set; } = new Models.Leerling();
    }
    class DataStore
    {
        ProjectData data;

        public Models.Leerling Leerling => data.LeerlingDetails;

        public void SetLeerling(Models.Leerling leerling)
        {
            data.LeerlingDetails = leerling;
        }
        public DataStore()
        {
            if (System.IO.File.Exists("data.json"))
            {
                var input = System.IO.File.ReadAllText("data.json");
                data = JsonConvert.DeserializeObject<ProjectData>(input);
            }
            else
            {
                data = new ProjectData();
            }

            public void SaveData()
            {
                var content = JsonConvert.SerializeObject(data, Formatting.Indented);
                System.IO.File.WriteAllText("package.json", content);
            }
        }
    }
}
