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

namespace RobotClient {
    public partial class main : Form {
        private const String DELIMITER = ";";
        private const String TRACKLINE = "TrackLine" + DELIMITER;
        private const String TRACKTURNLEFT = "TrackTurnLeft" + DELIMITER;
        private const String TRACKTURNRIGHT = "TrackTurnRight" + DELIMITER;
        private const String TRACKARCLEFT = "TrackArcLeft" + DELIMITER;
        private const String TRACKARCRIGHT = "TrackArcRight" + DELIMITER;
        private const String START = "Start";
        
        private Client client;
        private String command = TRACKLINE;
        private bool reqDistance, reqAngle;

        public main() {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e) {
        }

        private void connectionChanged(object sender, EventArgs e) {
            if (this.client.IsConnected) {
                grpConfig.Enabled = false;
                grpBasic.Enabled = true;
                grpProfessional.Enabled = true;
                statusClient.Text = "Connection: Established";
            } else {
                grpConfig.Enabled = true;
                grpBasic.Enabled = false;
                grpProfessional.Enabled = false;
                statusClient.Text = "Connection: Closed";
            }
        }

        private void cmdConnect_Click(object sender, EventArgs e) {
            IPAddress serverIP;
            int port;

            if (!IPAddress.TryParse(txtIpAddress.Text, out serverIP)) {
                MessageBox.Show("The entered ip address is invalid.", "Invalid ip address",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            port = (int)numPort.Value;
            this.client = new Client(serverIP, port);
            this.client.Connection += connectionChanged;

            // Enable other elements
            if (this.client.IsConnected) {
                grpConfig.Enabled = false;
                grpBasic.Enabled = true;
                grpProfessional.Enabled = true;
                statusClient.Text = "Connection: Established";
            }
        }

        private void Option_CheckedChanged(object sender, EventArgs e) {
            RadioButton option = (RadioButton)sender;

            switch (option.Name) {
                case "radioLine": {
                        txtDistance.Enabled = true;
                        txtAngle.Enabled = false;
                        this.reqDistance = true;
                        this.reqAngle = false;
                        this.command = TRACKLINE;
                        break;
                    }

                case "radioTurnL": {
                        txtDistance.Enabled = false;
                        txtAngle.Enabled = true;
                        this.reqDistance = false;
                        this.reqAngle = true;
                        this.command = TRACKTURNLEFT;
                        break;
                    }

                case "radioTurnR": {
                        txtDistance.Enabled = false;
                        txtAngle.Enabled = true;
                        this.reqDistance = false;
                        this.reqAngle = true;
                        this.command = TRACKTURNRIGHT;
                        break;
                    }

                case "radioArcL": {
                        txtDistance.Enabled = true;
                        txtAngle.Enabled = true;
                        this.reqDistance = true;
                        this.reqAngle = true;
                        this.command = TRACKARCLEFT;
                        break;
                    }

                case "radioArcR": {
                        txtDistance.Enabled = true;
                        txtAngle.Enabled = true;
                        this.reqDistance = true;
                        this.reqAngle = true;
                        this.command = TRACKARCRIGHT;
                        break;
                    }

                case "radioStart": {
                        txtDistance.Enabled = false;
                        txtAngle.Enabled = false;
                        this.reqDistance = false;
                        this.reqAngle = false;
                        this.command = START;
                        break;
                    }

                default: {
                        txtDistance.Enabled = true;
                        txtAngle.Enabled = false;
                        this.reqDistance = true;
                        this.reqAngle = false;
                        break;
                    }
            }
        }

        private void cmdSendProf_Click(object sender, EventArgs e) {
            String command = txtCommand.Text;
            float distance;
            int angle;
            String[] arrCommand = command.Split(' ');
            String commandPart = arrCommand[0];

            if (commandPart.Equals("L")) {
                if (arrCommand.Length < 2) {
                    MessageBox.Show("The entered command is invalid.", "Invalid command",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                float.TryParse(arrCommand[1], out distance);
                command = TRACKLINE + distance + ";";

            } else if (commandPart.Equals("TL") || commandPart.Equals("TR")) {
                if (arrCommand.Length < 2) {
                    MessageBox.Show("The entered command is invalid.", "Invalid command",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                int.TryParse(arrCommand[1], out angle);

                if (commandPart.Contains("L")) {
                    command = TRACKTURNLEFT;
                } else {
                    command = TRACKTURNRIGHT;
                }

                command += angle;

            } else if (commandPart.Equals("AL") || commandPart.Equals("AR")) {
                if (arrCommand.Length < 3) {
                    MessageBox.Show("The entered command is invalid.", "Invalid command",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                int.TryParse(arrCommand[1], out angle);
                float.TryParse(arrCommand[2], out distance);

                if (commandPart.Contains("L")) {
                    command = TRACKARCLEFT;
                } else {
                    command = TRACKARCRIGHT;
                }

                command += angle + ";" + distance;

            } else if (commandPart.Equals("S")) {
                if (arrCommand.Length < 1) {
                    MessageBox.Show("The entered command is invalid.", "Invalid command",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                command = START;
            }

            this.client.Send(command);
            listHistory.Items.Add(command);
            txtCommand.Clear();
            txtCommand.Focus();
        }

        private void txtAngle_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtDistance_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void txtDistance_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.V) {
                e.SuppressKeyPress = true;
            }
        }

        private void txtAngle_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.V) {
                e.SuppressKeyPress = true;
            }
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                cmdSendProf_Click(this, e);
            }
        }

        private void cmdSend_Click(object sender, EventArgs e) {
            float distance;
            int angle;

            if (this.reqDistance) {
                if (!float.TryParse(txtDistance.Text, out distance)) {
                    MessageBox.Show("The entered distance is invalid.", "Invalid distance",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                this.command += distance;
                if (this.reqAngle)
                {
                    this.command += ";";
                }
            }

            if (this.reqAngle) {
                if (!int.TryParse(txtAngle.Text, out angle)) {
                    MessageBox.Show("The entered angle is invalid.", "Invalid angle",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                this.command += angle;
            }

            this.client.Send(this.command);
            listHistory.Items.Add(this.command);
        }
    }
}
