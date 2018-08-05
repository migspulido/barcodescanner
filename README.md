# barcodescanner
This application allows you to enable and disable the Motorola barcode scanner used on the Dell rugged latitude tablet. The application depends on Interop.CoreScanner.dll which can be installed from the Motorola Scanner SDK.

There are two application projects, one to turn the barcode scanner on and one to turn the barcode scanner off. The default state of the scanner is to on. The applications are targeted to provide a path for turning the barcode scanner off in the event of extended use under battery power.

Usage:

BarcodeSwitchCOM-Off – Turns the barcode scanner off. To use it, you’ll need to double click the executable once – to set it into a mode that can be disabled. Wait a few seconds, then double click the executable again to disable the barcode scanner. You’ll know the scanner is disabled when you can no longer see the light on the scanner turn on when motion is detected in front of it. You can also drop this exe into C:\folder - then assign a button to control launching the .exe. This will help reduce the process down from a double click of the physical .exe to a single button click on the unit itself.

BarcodeSwitchCOM-On – Turns the barcode scanner on. To use it, simply double click on the executable and the barcode scanner will begin working if previously in the off position. You can test this out by applying motion in front of the scanner to see the light turn on. You can verify it actually scans by opening notepad.exe, scanning a barcode and seeing it displayed to the notepad application.

**Note: Both Motorola CoreScannerDriver and Motorola Scanner SDK should be installed on the target Dell rugged tablet for the applications to work.
