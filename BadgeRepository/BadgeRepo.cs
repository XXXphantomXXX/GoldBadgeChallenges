using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepository
{
    public class BadgeRepo
    {
        Dictionary<int, BadgePoco> _badgeDictionary = new Dictionary<int, BadgePoco>();

        public bool AddNewBadge(int badgeID, BadgePoco badge)
        {
            if (_badgeDictionary.ContainsKey(badgeID))
            {
                return false;
            }
            int Amount = _badgeDictionary.Count;
            _badgeDictionary.Add(badgeID, badge);
            return Amount < _badgeDictionary.Count;
        }
        public Dictionary<int, BadgePoco> GetBadge()
        {
            return _badgeDictionary;
        }
        public BadgePoco GetBadgeByID(int key)
        {
            if (_badgeDictionary.ContainsKey(key))
            {
                return _badgeDictionary[key];
            }
            else
            {
                return null;
            }
        }
        public bool RemoveDoorsFromBadge(int key, string door)
        {
            return _badgeDictionary[key].DoorNames.Remove(door);
        }
    }
}

