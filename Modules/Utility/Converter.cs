using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clove__Command_Line_ {
    public class Converter {
        public void ConverterUtil() {

            //variables for converter
            string input;
            double number;
            string firstUnit;
            string secondUnit;
            double finalNum;
            string outputMsg = "Your converted number is: ";
            string chosenMeasurement;

            //code ran when error
            void error() {
                Console.WriteLine("\t Please choose a unit from the list for both TO and FROM...\n");
                Console.WriteLine("\t Enter the following avaliable units: mm | cm | m | km | inch | ft | yard | mile\n");
            }

            //code ran for answer
            void answer() {
                Thread.Sleep(500);
                Console.WriteLine(outputMsg + finalNum + secondUnit + "\n");
                Console.WriteLine("-----------------------------------------------------\n");
                Thread.Sleep(1000);
                Console.WriteLine("\t Press enter to exit to menu...\n\n");
                Console.ReadLine();
                Console.Clear();
            }

            //length converter in converter module
            void length() {

                Console.Clear();
                while (true) {
                    //user input
                    Console.WriteLine("\n\t Enter a number:\n");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out number)) {
                        break;
                    } else {
                        Console.WriteLine("\t Please enter a number...\n");
                        Thread.Sleep(500);
                    }
                }

                Console.WriteLine("\n\t Enter the following avaliable units: mm | cm | m | km | inch | ft | yard | mile\n");

                while (true) {
                    Thread.Sleep(500);
                    //unit to convert from
                    Console.WriteLine("\t Enter unit to convert FROM:\n");
                    firstUnit = Console.ReadLine();
                    Console.WriteLine("\n");

                    Thread.Sleep(500);
                    //unit to convert to
                    Console.WriteLine("\t Enter unit to convert TO:\n");
                    secondUnit = Console.ReadLine();
                    Console.WriteLine("\n");

                    //check if both units are allowed
                    if (firstUnit == "mm" || firstUnit == "cm" || firstUnit == "m" || firstUnit == "inch" || firstUnit == "ft" || firstUnit == "yard" || firstUnit == "km" || firstUnit == "mile") {
                        if (secondUnit == "mm" || secondUnit == "cm" || secondUnit == "m" || secondUnit == "inch" || secondUnit == "ft" || secondUnit == "yard" || secondUnit == "km" || secondUnit == "mile") {
                            break;
                        } else {
                            error();
                        }
                    } else {
                        error();
                    }
                }
                //mm if statements
                if (firstUnit == "mm") {
                    if (secondUnit == "mm") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 0.1;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 0.001;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 0.000001;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 0.04;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 0.003281;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 0.001094;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.000000621;
                        answer();
                    }
                    //cm if statements
                } else if (firstUnit == "cm") {
                    if (secondUnit == "mm") {
                        finalNum = number * 10;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 0.01;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 0.00001;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 0.39;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 0.0328;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 0.0109;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.00000621;
                        answer();
                    }
                    //m if statements
                } else if (firstUnit == "m") {
                    if (secondUnit == "mm") {
                        finalNum = number * 1000;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 100;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 0.001;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 39.37;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 3.28;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 1.09;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.000621;
                        answer();
                    }
                    //km if statements
                } else if (firstUnit == "km") {
                    if (secondUnit == "mm") {
                        finalNum = number * 1000000;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 100000;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 1000;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 39370.08;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 3280.84;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 1093.61;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.62;
                        answer();
                    }
                    //inch if statements
                } else if (firstUnit == "inch") {
                    if (secondUnit == "mm") {
                        finalNum = number * 25.4;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 2.54;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 0.03;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 0.0000254;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 0.08;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 0.03;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.0000158;
                        answer();
                    }
                    //ft if statements
                } else if (firstUnit == "ft") {
                    if (secondUnit == "mm") {
                        finalNum = number * 304.8;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 30.48;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 0.3;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 0.000305;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 12;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 0.33;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.000189;
                        answer();
                    }
                    //yard if statements
                } else if (firstUnit == "yard") {
                    if (secondUnit == "mm") {
                        finalNum = number * 914.4;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 91.44;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 0.914;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 0.000914;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 36;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 3;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 0.000568;
                        answer();
                    }
                    //mile if statements
                } else if (firstUnit == "mile") {
                    if (secondUnit == "mm") {
                        finalNum = number * 1609344;
                        answer();
                    } else if (secondUnit == "cm") {
                        finalNum = number * 160934.4;
                        answer();
                    } else if (secondUnit == "m") {
                        finalNum = number * 1609.34;
                        answer();
                    } else if (secondUnit == "km") {
                        finalNum = number * 1.61;
                        answer();
                    } else if (secondUnit == "inch") {
                        finalNum = number * 63360;
                        answer();
                    } else if (secondUnit == "ft") {
                        finalNum = number * 5280;
                        answer();
                    } else if (secondUnit == "yard") {
                        finalNum = number * 1760;
                        answer();
                    } else if (secondUnit == "mile") {
                        finalNum = number * 1;
                        answer();
                    }
                }
            }

            //cooking converter in converter module
            void cooking() {
                Console.Clear();
                while (true) {
                    //user input
                    Console.WriteLine("\n\t Enter a number:\n");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out number)) {
                        break;
                    } else {
                        Console.WriteLine("\t Please enter a number...\n");
                        Thread.Sleep(500);
                    }
                }

                Console.WriteLine("\n\t Enter the following avaliable units: ml | l | UStsp | UStbsp | USoz | USpt | IMPtsp | IMPtbsp | IMPoz | IMPpt\n");

                while (true) {
                    Thread.Sleep(500);
                    //unit to convert from
                    Console.WriteLine("\t Enter unit to convert FROM:\n");
                    firstUnit = Console.ReadLine();
                    Console.WriteLine("\n");

                    Thread.Sleep(500);
                    //unit to convert to
                    Console.WriteLine("\t Enter unit to convert TO:\n");
                    secondUnit = Console.ReadLine();
                    Console.WriteLine("\n");

                    //check if units are valid
                    if (firstUnit == "ml" || firstUnit == "l" || firstUnit == "UStsp" || firstUnit == "UStbsp" || firstUnit == "USoz" || firstUnit == "USpt" || firstUnit == "IMPtsp" || firstUnit == "IMPtbsp" || firstUnit == "IMPoz" || firstUnit == "IMPpt") {
                        if (secondUnit == "ml" || secondUnit == "l" || secondUnit == "UStsp" || secondUnit == "UStbsp" || secondUnit == "USoz" || secondUnit == "USpt" || secondUnit == "IMPtsp" || secondUnit == "IMPtbsp" || secondUnit == "IMPoz" || secondUnit == "IMPpt") {
                            break;
                        } else {
                            error();
                        }
                    } else {
                        error();
                    }
                }
                //if statements for units
                if (firstUnit == "ml") {
                    if (secondUnit == "ml") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.001;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 0.2;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 0.07;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 0.03;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.002113;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 0.17;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 0.06;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 0.04;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.00176;
                        answer();
                    }
                } else if (firstUnit == "l") {
                    if (secondUnit == "ml") {
                        finalNum = number * 1000;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 202.88;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 67.63;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 33.81;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 2.11;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 168.94;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 56.31;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 35.2;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 1.76;
                        answer();
                    }
                } else if (firstUnit == "UStsp") {
                    if (secondUnit == "ml") {
                        finalNum = number * 4.93;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.004929;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 0.33;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 0.17;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.01;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 0.83;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 0.28;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 0.17;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.01;
                        answer();
                    }
                } else if (firstUnit == "UStbsp") {
                    if (secondUnit == "ml") {
                        finalNum = number * 14.79;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.01;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 3;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 0.5;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.03;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 2.5;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 0.83;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 0.52;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.03;
                        answer();
                    }
                } else if (firstUnit == "USoz") {
                    if (secondUnit == "ml") {
                        finalNum = number * 29.57;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.03;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 6;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 2;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.06;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 5;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 1.67;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 1.04;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.05;
                        answer();
                    }
                } else if (firstUnit == "USpt") {
                    if (secondUnit == "ml") {
                        finalNum = number * 473.18;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.47;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 96;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 32;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 16;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 79.94;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 26.65;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 16.65;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.83;
                        answer();
                    }
                } else if (firstUnit == "IMPtsp") {
                    if (secondUnit == "ml") {
                        finalNum = number * 5.92;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.01;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 1.2;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 0.4;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 0.2;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.01;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 0.33;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 0.21;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.01;
                        answer();
                    }
                } else if (firstUnit == "IMPtbsp") {
                    if (secondUnit == "ml") {
                        finalNum = number * 17.76;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.02;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 3.6;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 1.2;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 0.6;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.04;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 3;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 0.62;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.03;
                        answer();
                    }
                } else if (firstUnit == "IMPoz") {
                    if (secondUnit == "ml") {
                        finalNum = number * 28.41;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.03;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 5.76;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 1.92;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 0.96;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 0.06;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 4.8;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 1.6;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 1;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 0.05;
                        answer();
                    }
                } else if (firstUnit == "IMPpt") {
                    if (secondUnit == "ml") {
                        finalNum = number * 568.26;
                        answer();
                    } else if (secondUnit == "l") {
                        finalNum = number * 0.57;
                        answer();
                    } else if (secondUnit == "UStsp") {
                        finalNum = number * 115.29;
                        answer();
                    } else if (secondUnit == "UStbsp") {
                        finalNum = number * 38.43;
                        answer();
                    } else if (secondUnit == "USoz") {
                        finalNum = number * 19.22;
                        answer();
                    } else if (secondUnit == "USpt") {
                        finalNum = number * 1.2;
                        answer();
                    } else if (secondUnit == "IMPtsp") {
                        finalNum = number * 96;
                        answer();
                    } else if (secondUnit == "IMPtbsp") {
                        finalNum = number * 32;
                        answer();
                    } else if (secondUnit == "IMPoz") {
                        finalNum = number * 20;
                        answer();
                    } else if (secondUnit == "IMPpt") {
                        finalNum = number * 1;
                        answer();
                    }
                }
            }
            while (true) {
                //draw UI
                Console.WriteLine("\n\t\t\t ▒▒▒░░░▒▒▒░░░▒▒░░░▒▒▒░░░▒▒▒");
                Console.WriteLine("\t\t\t ░░░                    ░░░");
                Console.WriteLine("\t\t\t ▒▒▒  Converter Module  ▒▒▒");
                Console.WriteLine("\t\t\t ░░░                    ░░░");
                Console.WriteLine("\t\t\t ▒▒▒░░░▒▒▒░░░▒▒░░░▒▒▒░░░▒▒▒\n");

                Thread.Sleep(500);
                //user selection
                Console.WriteLine("\t What measurement would you like to convert: (length | cooking | exit)\n");
                chosenMeasurement = Console.ReadLine();
                Console.WriteLine("\n");

                //module selection if statements
                if (chosenMeasurement.ToLower() == "length" || chosenMeasurement.ToLower() == "l") {
                    Thread.Sleep(500);
                    length();
                } else if (chosenMeasurement.ToLower() == "cooking" || chosenMeasurement.ToLower() == "c") {
                    Thread.Sleep(500);
                    cooking();
                } else if (chosenMeasurement.ToLower() == "exit" || chosenMeasurement.ToLower() == "e") {
                    Thread.Sleep(200);
                    Console.Clear();
                    break;
                } else {
                    Console.WriteLine("\t Please choose a measurement from the following...\n\n");
                    Thread.Sleep(500);
                }
            }
        }
    }
}
