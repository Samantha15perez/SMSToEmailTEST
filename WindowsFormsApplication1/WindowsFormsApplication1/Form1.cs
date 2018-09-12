using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Windows;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool SendMessage = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            

            try
            {
                string mailBodyhtml = "<p>" + textBoxMessageBody.Text + "</p>";

                if (mailBodyhtml.Length > 150 && radioButtonVerizon.Checked == false)
                {
                    MessageBox.Show("Keep it under 150 characters please!");
                    SendMessage = false;
                }else
                {
                    SendMessage = true;
                }

                var msg = new MailMessage("samstestapplication@gmail.com", "samantha15perez@gmail.com", "", mailBodyhtml);

                if (radioButtonVerizon.Checked == true)
                {
                    msg.To.Add(textBoxMessageRecipient.Text + "@Vtext.com");

                    if(mailBodyhtml.Length > 150)
                    {
                        msg.To.Add(textBoxMessageRecipient.Text + "@vzwpix.com");
                    }

                }
                if (radioButtonATT.Checked == true)
                {
                    msg.To.Add(textBoxMessageRecipient.Text + "@txt.att.net");
                }
                if (radioButtonSprint.Checked == true)
                {
                    msg.To.Add(textBoxMessageRecipient.Text + "@messaging.sprintpcs.com");
                }
                if (radioButtonMetro.Checked == true)
                {
                    msg.To.Add(textBoxMessageRecipient.Text + "@mymetropcs.com");
                }
                if (radioButtonCricket.Checked == true)
                {
                    msg.To.Add(textBoxMessageRecipient.Text + "@mms.cricketwireless.net");
                }

                msg.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.gmail.com", 587); //if your from email address is "from@hotmail.com" then host should be "smtp.hotmail.com"**
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential("samstestapplication@gmail.com", "Fullmetal_69");
                smtpClient.EnableSsl = true;

                if (SendMessage == true)
                {
                    smtpClient.Send(msg);
                    MessageBox.Show("Email Sent Successfully");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
