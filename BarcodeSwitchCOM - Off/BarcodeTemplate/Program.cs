/*Miguel Pulido
 * Systems Architect
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CoreScanner;

namespace BarcodeTemplate
{
    class Program
    {
        /* Declare CoreScannerClass*/
        static CCoreScannerClass cCoreScannerClass;
        
        static void Main(string[] args)
        {
            /* Instatiate CoreScanner Class */
            cCoreScannerClass = new CoreScanner.CCoreScannerClass();

            //Call Open API
            short[] scannerTypes = new short[1]; // Scanner Types you are interested in
            scannerTypes[0] = 1; // 1 for all scanner types
            short numberOfScannerTypes = 1; // Size of the scannerTypes array
            int status; // Extended API return code
            
            cCoreScannerClass.Open(0, scannerTypes, numberOfScannerTypes, out status);
            

            /* Let's switch communication protocol */
            int opcode = 6200;          //Method for switch
            string outXML;              //Output
            string inXml = "<inArgs>" +
                               "<scannerID>1</scannerID>" + // The scanner you need
                               "<cmdArgs>" +
                                   "<arg-string>XUA-45001-9</arg-string>" +    //Target switch to SNAPI
                //Host Variant
                                   "<arg-bool>FALSE</arg-bool>" +              //Silent Switch
                //Option
                                   "<arg-bool>FALSE</arg-bool>" +              //Permanent
                //Change Option
                               "</cmdArgs>" +
                           "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXml, out outXML, out status);


            /* Let's disable scanning on for SNAPI -- as tested on SDK */
            int code = 2013;          //Method for SCAN_DISABLE
            string outXml;              //Output
            string inXML = "<inArgs>" +
                               "<scannerID>1</scannerID>" + // The scanner you need
                           "</inArgs>";
            cCoreScannerClass.ExecCommand(code, ref inXML, out outXml, out status);


        }
    }
}
