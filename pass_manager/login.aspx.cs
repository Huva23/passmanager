using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace pass_manager
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private async Task<bool> AuthenticateUser(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://yourserver.com/path/to/your/authenticate_user.php"; // Replace with the URL to your PHP script
                var values = new Dictionary<string, string>
        {
            { "username", username },
            { "password", password }
        };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var result = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, bool>>(jsonResponse);
                    return result["isAuthenticated"];
                }
                else
                {
                    // Handle error or return false
                    return false;
                }
            }
        }

        protected async void Login_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            // Call the AuthenticateUser function asynchronously
            bool isAuthenticated = await AuthenticateUser(user, pass);
            if (isAuthenticated)
            {
                // Redirect to the user's dashboard
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                // Display an error message
            }
        }

    }
}