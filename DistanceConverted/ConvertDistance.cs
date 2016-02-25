using System;
using System.Collections.Generic;
using System.Text;
namespace DistanceConverted
{
    public class ConvertDistance
    {
        double Distance { get; set; }
        string OldUnits {get; set;}
        string NewUnits { get; set; }
        //Methods
        public string[] Convert(double distance, string oldUnits, string newUnits)
        {   
            string[] result = {"","",""};
            //convert from inches
            if (oldUnits == "inches")
            {
                //convert to inches/cm/cm
                if (newUnits == "inches")
                {
                    result[0] = (distance * 1).ToString() + " inches";
                    result[1] = Math.Round(distance *2.54, 2).ToString() +" centimeters";
                    result[2] = result[1];
                }
                //convert to feet/cm/m
                else if (newUnits == "feet")
                {
                    result[0] = Math.Round(distance / 12, 2).ToString() + " feet";
                    result[1] = Math.Round(distance *2.54, 2).ToString() + " centimeters";
                    result[2] = Math.Round(distance * 0.0254, 4).ToString() + " meters";
                }
                //convert to yards/cm/m
                else if (newUnits == "yards")
                {
                    result[0] = Math.Round(distance / 36, 2).ToString() + " yards";
                    result[1] = Math.Round(distance *2.54, 2).ToString() + " centimeters";
                    result[2] = Math.Round(distance * 0.0254, 4).ToString() + " meters";
                }
                //convert to miles/cm/km
                else
                {
                    result[0] = Math.Round(distance / 63360, 2).ToString() + " miles";
                    result[1] = Math.Round(distance *2.54, 2).ToString() + " centimeters";
                    result[2] = Math.Round(distance * 0.0000254, 7).ToString() + " kilometers";
                }
            }
            //convert from feet
            else if (oldUnits == "feet")
            {
                //convert to inches/m/cm
                if (newUnits == "inches")
                {
                    result[0] = (distance*12).ToString() + " inches";
                    result[1] = Math.Round(distance *0.3048, 4).ToString() + " meters";
                    result[2] = Math.Round(distance * 30.48, 2).ToString() + " centimeters";
                }
                //convert to feet/m/m
                else if (newUnits == "feet")
                {
                    result[0] = (distance).ToString() + " feet";
                    result[1] = Math.Round(distance * 0.3048, 4).ToString() + " meters";
                    result[2] = result[1];
                }
                //convert to yards/m/m
                else if (newUnits == "yards")
                {
                    result[0] = Math.Round(distance / 3, 2).ToString() + " yards";
                    result[1] = Math.Round(distance * 0.3048, 4).ToString() + " meters";
                    result[2] = result[1];
                }
                //convert to miles/m/km
                else
                {
                    result[0] = Math.Round(distance / 5280, 2).ToString() + " miles";
                    result[1] = Math.Round(distance * 0.3048, 4).ToString() + " meters";
                    result[2] = Math.Round(distance * 0.0003048, 7).ToString() + " kilometers";
                }
            }
            //convert from yards
            else if (oldUnits == "yards")
            {
                //convert to inches/m/cm
                if (newUnits == "inches")
                {
                    result[0] = (distance*36).ToString() + " inches";
                    result[1] = Math.Round(distance*0.9144, 4).ToString() + " meters";
                    result[2] = Math.Round(distance * 91.44, 2).ToString() + " centimeters";
                }
                //convert to feet/m/m
                else if (newUnits == "feet")
                {
                    result[0] = (distance*3).ToString() + " feet";
                    result[1] = Math.Round(distance *.9144, 4).ToString() + " meters";
                    result[2] = result[1];
                }
                //convert to yards/m/m
                else if (newUnits == "yards")
                {
                    result[0] = (distance).ToString() + " yards";
                    result[1] = Math.Round(distance *.9144, 4).ToString() + " meters";
                    result[2] = result[1];
                }
                //convert to miles/m/km
                else
                {
                    result[0] = Math.Round(distance / 1760, 2).ToString() + " miles";
                    result[1] = Math.Round(distance * 0.9144, 4).ToString() + " meters";
                    result[2] = Math.Round(distance * 0.0009144, 7).ToString() + " kilometers";
                }

            }
            //convert from miles
            else
            {
                //convert to inches/km/cm
                if (newUnits == "inches")
                {
                    result[0] = (distance * 63360).ToString() + " inches";
                    result[1] = Math.Round(distance * 1.60934, 2).ToString() + " kilometers";
                    result[2] = (distance * 160934).ToString() + " centimeters";
                }
                //convert to feet/km/m
                else if (newUnits == "feet")
                {
                    result[0] = (distance * 5280).ToString() + " feet";
                    result[1] = Math.Round(distance * 1.60934, 2).ToString() + " kilometers";
                    result[2] = Math.Round(distance * 1609.34, 2).ToString() + " meters";
                }
                //convert to yards/km/m
                else if (newUnits == "yards")
                {
                    result[0] = (distance * 1760).ToString() + " yards";
                    result[1] = Math.Round(distance * 1.60934, 2).ToString() + " kilometers";
                    result[2] = Math.Round(distance * 1609.34, 2).ToString() + " meters";
                }
                //convert to miles/km/km
                else
                {
                    result[0] = (distance).ToString() + " miles";
                    result[1] = Math.Round(distance * 1.60934, 2).ToString() + " kilometers";
                    result[2] = result[1];
                }
            }
            return result;
        }

    }


}