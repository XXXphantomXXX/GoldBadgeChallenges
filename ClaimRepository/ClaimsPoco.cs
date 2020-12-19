using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimRepository
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft,
    }
    public class ClaimsPoco
    {
        public int ClaimID { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public ClaimType TypeOfClaim { get; set; }

        public ClaimsPoco()
        {

        }
        public ClaimsPoco(int claimID, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid, ClaimType typeOfClaim)
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfClaim = dateOfClaim;
            DateOfIncident = dateOfIncident;
            IsValid = isValid;
            TypeOfClaim = typeOfClaim;
        }
    }
}
