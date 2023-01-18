using Api_Integrated_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//change 1
namespace CentralInsuranceCargoPolicyTest
{
    public partial class CargoTestForm : Form
    {
        ApiCallsServices _ApiCallsServices;
        Log _log = new Log();
        Stopwatch watch;
        public CargoTestForm()
        {
            InitializeComponent();
            watch = new Stopwatch();

        }

        private void apptokenbtn_Click(object sender, EventArgs e)
        {

            clientloginbtn.Enabled = false;
            cargobtn.Enabled = false;
            
            if (txtBasePath.Text == "")
                _ApiCallsServices = new ApiCallsServices();
            else
                _ApiCallsServices = new ApiCallsServices(txtBasePath.Text);

            txtboxResult.Text += _log.WriteResultTextBox("ApiManager AppLogin start ...");
            watch.Restart();
            if (txtAppUser.Text == "" || txtAppSecrect.Text == "")
            {
                    var t = Task.Run(async () => {
                        await _ApiCallsServices.ApimanagerAppLogin();

                    });
                t.Wait();
            }
                
           
            else
            {
                var t = Task.Run(async () => { 
                   await _ApiCallsServices.ApimanagerAppLogin(txtAppUser.Text, txtAppSecrect.Text);

                });
                t.Wait();

            }
            watch.Stop();
            time.Text = "Time : " + watch.ElapsedMilliseconds.ToString() + " ms";

            if (AthenticationData.appTokenFlag)
            {
                txtboxResult.Text += _log.WriteResultTextBox("ApiManager AppLogin Sucsecced");
                txtboxResult.Text += _log.WriteResultTextBox("AppToken Is :" + AthenticationData.appToken);
                clientloginbtn.Enabled = true;
            }
            else
                txtboxResult.Text += _log.WriteResultTextBox("ApiManager AppLogin Faild");

        }

        private void clientlogin_Click(object sender, EventArgs e)
        {
            watch.Restart();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                var t = Task.Run(async () => {
                    await _ApiCallsServices.ApimanagerClientLogin();

                });
                t.Wait();

            }

            else
            {
                var t = Task.Run(async () => {
                    await _ApiCallsServices.ApimanagerClientLogin(txtUsername.Text, txtPassword.Text);

                });
                t.Wait();

            }
            watch.Stop();
            time.Text = "Time : " + watch.ElapsedMilliseconds.ToString() + " ms";
            if (AthenticationData.authenticationTokenFlag)
            {
                txtboxResult.Text += _log.WriteResultTextBox("ApiManager ClientLogin Sucsecced");
                txtboxResult.Text += _log.WriteResultTextBox("AuthenticationToken Is :" + AthenticationData.authenticationToken);
                cargobtn.Enabled = true;
            }
            else
                txtboxResult.Text += _log.WriteResultTextBox("ApiManager Client Login Faild");

        }

        private async void cargobtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            txtboxResult.Text += _log.WriteResultTextBox("Send A Request To Alborz CargoPolicy BimeApi");
            watch.Restart();
            var t = Task.Run(() =>
            {
                httpResponseMessage = _ApiCallsServices.CargoPaliciesCall("24", "6", "100", txtJsonInput.Text);

            });

            t.Wait();
            watch.Stop();
            time.Text = "Time : " + watch.ElapsedMilliseconds.ToString() + " ms";
            if (httpResponseMessage == null)
                txtboxResult.Text += _log.WriteResultTextBox("Error :Time Out After 30 Second . . . ");
            else
                OutPuttxt.Text = await _log.Response_writeTofileAsync(httpResponseMessage);

        }
        //this comment use only for test
        private void CargoTestForm_Load(object sender, EventArgs e)
        {
            clientloginbtn.Enabled = false;
            cargobtn.Enabled = false;

            ///
            /*
             * This paragraph illustrate a concept for Test ability of pull request
             * 
             * 
             */
        }
    }
}
