using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace SpaceXWebsite
{
    //root class for launch
    public class Launch
    {
        public String launch_date_local { get; set; }
        public String mission_name { get; set; }
        public String launch_success { get; set; }

        public Rocket rocket { get; set; }
        public Links links { get; set; }

    }

    //rocket data
    public class Rocket
    {
        public String rocket_name { get; set; }
    }

    //launch links
    public class Links
    {
        public String presskit { get; set; }
    }

    public partial class Launches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creating the request
            String url = "https://api.spacexdata.com/v2/launches/";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            //Sending request to API
            var response = (HttpWebResponse)request.GetResponse();

            //Reading response
            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using(var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }

            //Turning JSON into an array of launches
            JavaScriptSerializer js = new JavaScriptSerializer();
            Launch[] launches = js.Deserialize<Launch[]>(content);


            //Outputting retrieved data into html table
            for (int i = 0; i < launches.Length; i++)
            {
                TableRow launch = new TableRow();
                launchesTable.Rows.Add(launch);

                TableCell dateCell = new TableCell();
                DateTime lDate = DateTime.Parse(launches[i].launch_date_local);
                dateCell.Text = lDate.ToString("MM/dd/yyyy HH:mm");
                launch.Cells.Add(dateCell);

                TableCell nameCell = new TableCell();
                nameCell.Text = launches[i].rocket.rocket_name;
                launch.Cells.Add(nameCell);

                TableCell cargoCell = new TableCell();
                cargoCell.Text = "<a href =\"" +launches[i].links.presskit + "\">" + launches[i].links.presskit + "</a>";
                launch.Cells.Add(cargoCell);

                TableCell successCell = new TableCell();
                successCell.Text = launches[i].launch_success;
                launch.Cells.Add(successCell);
            }
        }
    }
}