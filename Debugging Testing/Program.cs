using System;
using System.Collections.Generic;

namespace Debugging_Testing {
    class Program {
        static void Main(string[] args) {
            var friends = new List<string> { "Dave", "Ian", "Bondar", "Ben", "Jay", "Chris B", "George", "JC" };
            var partyFriends = GetPartyFriends(friends, 3);
            foreach(var f in partyFriends) {
                Console.WriteLine(f);
            }
        }
        public static List<string> GetPartyFriends(List<string> list, int count) {
            var partyFriends = new List<string>();
            while (partyFriends.Count < count) {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }
        public static string GetPartyFriend(List<string> list) {

            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++) {
                if (list[i].Length > shortestName.Length) {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    
    }
}
