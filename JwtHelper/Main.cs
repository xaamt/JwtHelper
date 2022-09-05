using JwtHelper.TokenService;

using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace JwtHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Reload();
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {
            var identity = JwtTokenService.GetPrincipalFromExpiredToken(txtJwt.Text, cbDefaultKey.Checked, txtKey.Text);
            if (identity == null)
            {
                Reload();
                txtIsAuthenticated.Text = "Token is not valid!";
                txtIsAuthenticated.ForeColor = Color.Red;
                return;
            }

            SetBasicInfo(identity);
            SetApplicationList(identity);
            SetRoleList(identity);
            SetJsonContent(identity);
        }

        /// <summary>
        /// Reload form
        /// </summary>
        public void Reload()
        {
            txtJwt.ResetText();
            cbDefaultKey.Checked = true;
            btnCopy.Enabled = false;
            txtJsonContent.ResetText();
            lvApplications.Items.Clear();
            lvRoles.Items.Clear();

            txtUserId.ResetText();
            txtUsername.ResetText();
            txtFullName.ResetText();
            txtPosition.ResetText();
            txtBranchId.ResetText();
            txtBranchName.ResetText();
            txtIssuerInfo.ResetText();

            txtIsAuthenticated.ResetText();
            txtIsValid.ResetText();
            txtIssuedAt.ResetText();
            txtNotBefore.ResetText();
            txtExpiredAt.ResetText();
            txtExpireUntil.ResetText();

            cbDefaultKey_CheckedChanged(null, null);
            tabs.SelectTab(0);
            txtJwt.Focus();
        }

        /// <summary>
        /// clear and set basic info
        /// </summary>
        /// <param name="identity"></param>
        private void SetBasicInfo(TokenIdentity identity)
        {
            txtUserId.Text = identity.UserId.ToString();
            txtUsername.Text = identity.Username;
            txtFullName.Text = identity.UserFullName;
            txtPosition.Text = identity.Position;
            txtBranchId.Text = identity.BranchId.ToString();
            txtBranchName.Text = identity.BranchName;
            txtIssuerInfo.Text = identity.Issuer;

            txtIsAuthenticated.Text = identity.IsAuthenticated.ToString();
            txtIsAuthenticated.ForeColor = identity.IsAuthenticated ? Color.Green : Color.Red;
            txtIsValid.Text = identity.IsValid.ToString();
            txtIsValid.ForeColor = identity.IsValid ? Color.Green : Color.Red;
            txtIssuedAt.Text = identity.IssueAt.ToString("yyyy/MM/dd HH:mm:ss", new CultureInfo("Fa-Ir"));
            txtNotBefore.Text = identity.NotBefore.ToString("yyyy/MM/dd HH:mm:ss", new CultureInfo("Fa-Ir"));
            txtNotBefore.ForeColor = identity.NotBefore < DateTime.Now ? Color.Green : Color.Red;
            txtExpiredAt.Text = identity.ExpireAt.ToString("yyyy/MM/dd HH:mm:ss", new CultureInfo("Fa-Ir"));

            if (DateTime.Now < identity.ExpireAt)
            {
                var elapsedSpan = identity.ExpireAt - DateTime.Now;
                txtExpireUntil.Text = $"{elapsedSpan.Days:N0} days, {elapsedSpan.Hours} hours, {elapsedSpan.Minutes} minutes, {elapsedSpan.Seconds} seconds";
                txtExpireUntil.ForeColor = Color.Green;
                txtExpiredAt.ForeColor = Color.Green;
            }
            else
            {
                txtExpireUntil.Text = "Expiry passed";
                txtExpireUntil.ForeColor = Color.Red;
                txtExpiredAt.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Clear and set json
        /// </summary>
        /// <param name="identity"></param>
        private void SetJsonContent(TokenIdentity identity)
        {
            txtJsonContent.Text = identity.JsonContent;
        }

        /// <summary>
        /// Clear and set applications
        /// </summary>
        /// <param name="identity"></param>
        private void SetApplicationList(TokenIdentity identity)
        {
            lvApplications.Items.Clear();
            var index = 1;

            foreach (var app in identity.Audience.OrderBy(x => x))
            {
                //add items to ListView
                var arr = new string[5];
                arr[0] = index++.ToString();
                arr[1] = app;
                var title = "";
                ApplicationsDatabase.Applications.TryGetValue(app.ToLower(), out title);
                arr[2] = title;

                var isAdmin = identity.AdminInApp.Any(i => i.ToLower() == app.ToLower());
                arr[3] = isAdmin.ToString();

                var roleCount = identity.Roles.Count(i => i.StartsWith(app));
                arr[4] = roleCount.ToString();

                var item = new ListViewItem(arr);

                item.SubItems[3].ForeColor = isAdmin ? Color.Green : Color.Red;
                item.SubItems[4].ForeColor = roleCount > 0 ? Color.Green : Color.Red;

                var listItem = lvApplications.Items.Add(item);
                listItem.UseItemStyleForSubItems = false;
            }
        }

        /// <summary>
        /// Clear and set roles
        /// </summary>
        /// <param name="identity"></param>
        private void SetRoleList(TokenIdentity identity)
        {
            lvRoles.Items.Clear();
            var index = 1;

            foreach (var role in identity.Roles.OrderBy(x => x))
            {
                //add items to ListView
                var arr = new string[5];

                var temp = role.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length == 2)
                {
                    arr[0] = index++.ToString();
                    arr[1] = temp[0];
                    arr[2] = temp[1];

                    var isValid = identity.Audience.Any(i => i.ToLower() == temp[0].ToLower());
                    arr[3] = isValid.ToString();

                    var isAdmin = identity.AdminInApp.Any(i => i.ToLower() == temp[0].ToLower());
                    arr[4] = isAdmin.ToString();

                    var item = new ListViewItem(arr);

                    item.SubItems[3].ForeColor = isValid ? Color.Green : Color.Red;
                    item.SubItems[4].ForeColor = isAdmin ? Color.Green : Color.Red;


                    var listItem = lvRoles.Items.Add(item);
                    listItem.UseItemStyleForSubItems = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tslblPoweredBy_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://www.xamt.pro");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
            MessageBox.Show("Jwt Token Helper app has been reloaded", "Reload the application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtJwt.Text = Clipboard.GetText();
        }

        private void txtJwt_TextChanged(object sender, EventArgs e)
        {
            lblContentLength.Text = $"Length: {txtJwt.TextLength}";
        }

        private void txtJsonContent_TextChanged(object sender, EventArgs e)
        {
            lblJsonContentLength.Text = $"Length: {txtJsonContent.TextLength}";
            btnCopy.Enabled = lblJsonContentLength.Text.Length > 0;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtJsonContent.Text);
            MessageBox.Show("Json Content has been copied to clipboard", "Copy to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbDefaultKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDefaultKey.Checked)
            {
                txtKey.ResetText();
                txtKey.Text = "Fake Password";
                txtKey.Enabled = false;
                txtKey.PasswordChar = '*';
            }
            else
            {
                txtKey.ResetText();
                txtKey.Enabled = true;
                txtKey.PasswordChar = default;
                txtKey.Focus();
            }
        }
    }
}
