using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
           //check if the wave already exist or not
            if(_roster.ContainsKey(wave))
            {

              _roster[wave].Add(cadet);
            }
            else
            {
                _roster.Add(wave, new List<string>());
                _roster[wave].Add(cadet);
            }
            
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
          //Dictionary<int,List<string>>  rost1 = new Dictionary<int, List<String>>();
            var list = new List<string>();
          
           if(_roster.ContainsKey(wave))
           {
               foreach(string s in _roster[wave])
               {
                   list.Add(s);
               }
               list.Sort();
           }
            
            return list;
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets=new List<string>();
            var waves=new List<int>();
            waves=_roster.Keys.ToList();
            //sort a list of wave first
            waves.Sort();
            foreach(int i in waves)
            {
                //sort the names of each sorted wave
                _roster[i].Sort();
                foreach(string s in _roster[i])
                {
                
                  cadets.Add(s);
                }
            }
            return cadets;
        }
    }
}
