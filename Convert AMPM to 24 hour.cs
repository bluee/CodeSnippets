using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

class Solution {

    static void Main(String[] args) {
        
            CultureInfo provider = CultureInfo.InvariantCulture;
            string time = Console.ReadLine(); 
            var result = DateTime.ParseExact(time, "hh:mm:sstt", provider);
            Console.WriteLine(result.ToString("HH:mm:ss"));
    }
}

