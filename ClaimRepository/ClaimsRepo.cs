using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimRepository  
{
    public class  ClaimsRepo
    {
        private readonly Queue<ClaimsPoco> _claimsQ = new Queue<ClaimsPoco>();

        //create 
        public void AddClaim(ClaimsPoco claims)
        {
            _claimsQ.Enqueue(claims);
        }

        //read
        public Queue<ClaimsPoco> GetClaims()
        {
            return _claimsQ;
        }
        public ClaimsPoco CurrentClaim()
        {
            return _claimsQ.Peek();
        }

        //update
        public bool UpdateClaim(int OriginalClaimID, ClaimsPoco NewClaim)
        {
            ClaimsPoco oldclaim = GetClaimByID(OriginalClaimID);

            if(oldclaim != null)
            {
                oldclaim.ClaimID = NewClaim.ClaimID;
                oldclaim.Description = NewClaim.Description;
                oldclaim.ClaimAmount = NewClaim.ClaimAmount;
                oldclaim.DateOfIncident = NewClaim.DateOfIncident;
                oldclaim.DateOfClaim = NewClaim.DateOfClaim;
                oldclaim.IsValid = NewClaim.IsValid;
                oldclaim.TypeOfClaim = NewClaim.TypeOfClaim;
                return true;
            }
                
            else
            {
                return false;
            }
        }
        //delete
        public void RemoveClaim()
        { 
            _claimsQ.Dequeue();
        }
            

        //helper
        private ClaimsPoco GetClaimByID(int ClaimID)
        {
            foreach(ClaimsPoco claims in _claimsQ)
            {
                if(claims.ClaimID == ClaimID)
                {
                    return claims;
                }
            }
            return null;
        }

    }
}
