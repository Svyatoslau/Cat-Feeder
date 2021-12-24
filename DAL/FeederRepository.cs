using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using Model.Ententity;
using MySql.Data.MySqlClient;
using System.Data;
using Model1.Ententity;

namespace DAL
{
    public class FeederRepository : IRepository<Feeder>
    {
        public void Add(Feeder feeder)
        {
            int id = 0;
            int count_feeder = 0;
            count_feeder = DBHelper.getCountRow("feeder");
            if (count_feeder > 0) id = count_feeder + 1;
            DBHelper.AddUser(id.ToString(), feeder.Name, feeder.Value.ToString(), feeder.Type);
        }

        public Feeder Find(string name)
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            Feeder feeder = null;
            Developer dev = null; 
            string query = "SELECT * FROM mydb.feeder WHERE Name = (@name) limit 1";
            cmd = DBHelper.RunQuery(query, name);
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uName = dr["Name"].ToString();
                    int value =Int32.Parse(dr["value"].ToString());
                    string type = dr["type"].ToString();
                    
                    if (type.Equals("Sensor"))
                    {
                        dev = new SensorDeveloper();
                    }else if (type.Equals("Dispenser"))
                    {
                        dev = new SensorDeveloper();
                    }

                    feeder = dev.Create(uName, value);
                }
            }
            return feeder;
        }

        public IEnumerable<Feeder> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Feeder feeder)
        {
            Feeder update_feeder = this.Find(feeder.Name);
            feeder.Name = update_feeder.Name;
            feeder.Value = update_feeder.Value;
            feeder.Type = update_feeder.Type;
        }
    }
}
