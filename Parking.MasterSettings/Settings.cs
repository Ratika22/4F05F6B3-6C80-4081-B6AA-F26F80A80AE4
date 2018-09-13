using System;
using System.Windows.Forms;
using Parking.Database.CommandFactory;

namespace Parking.MasterSettings
{
    public partial class Settings : Form
    {
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;

        public Settings()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void BtnSaveSettingsClick(object sender, EventArgs e)
        {
            parkingDatabaseFactory.UpdateMasterSettings(txtCompanyName.Text,
                                                        txtParkingPlaceCode.Text,
                                                        txtParkingPlaceName.Text,
                                                        txtTwoWheelerParkingChargesPerHour.Text,
                                                        txtFourWheelerParkingChargesPerHour.Text,
                                                        txtLostTicketPenalty.Text,
                                                        txtPLCBoardPortNumber.Text,
                                                        txtServerIP.Text);
            LoadSettings();
            Hide();
        }

        private void LoadSettings()
        {
            var dr = parkingDatabaseFactory.GetMasterSettings();
            txtCompanyName.Text = dr[0].ToString();
            txtParkingPlaceCode.Text = dr[1].ToString();
            txtParkingPlaceName.Text = dr[2].ToString();
            txtTwoWheelerParkingChargesPerHour.Text = dr[3].ToString();
            txtFourWheelerParkingChargesPerHour.Text = dr[4].ToString();
            txtLostTicketPenalty.Text = dr[5].ToString();
            txtPLCBoardPortNumber.Text = dr[6].ToString();
        }
    }
}
