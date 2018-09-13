﻿using System.Data;

namespace Parking.Interfaces
{
    public interface IParkingDatabaseFactory
    {
        void UpdateMasterSettings(string companyName, string parkingPlaceCode, string parkingPlaceName, string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour, string lostTicketPenality, string plcBoardPortNumber, string serverIp);

        DataRow GetMasterSettings();
    }
}