using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak03
{
    public partial class AsyncFetch : Form
    {
        public AsyncFetch()
        {
            InitializeComponent();
        }

        private const string FETCH_URL = "https://reqres.in/api/users";

        private async void AsyncFetch_OnLoad(object sender, EventArgs e)
        {
            lbInfo.Text = "Fetching...";
            try {
                Data data = await GetDataAsync();
                lbInfo.Text = "Done.";
                cbSelect.DataSource = data.Users;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                lbInfo.Text = ex.Message;
            }
        }

        private Task<Data> GetDataAsync()
        {
            return Task.Run(() =>
            {
                var apiClient = new RestClient(FETCH_URL);
                RestRequest req = new RestRequest(Method.GET);
                
                string hold = apiClient.Execute(req).Content;
                Data data = JsonConvert.DeserializeObject<Data>(hold);
                return data;
            });
        }
    }
}
