﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AdventureWorks.Model;
using AdventureWorks.BusinessCore;

namespace AdventureWorks.ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ShiftService : IShiftService
    {
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/")]
        public List<Shift> GetAllShifts()
        {
            List<Shift> allShifts = CoreFactory.GetInstance().ShiftBusinessLogic.GetAllShifts();
            return allShifts;
        }

        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/{shiftID}")]
        public Shift GetShift(string shiftID)
        {
            Shift shift = CoreFactory.GetInstance().ShiftBusinessLogic.GetShift(Int32.Parse(shiftID));
            return shift;
        }
    }
}
