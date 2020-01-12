# LemonWay_Challenge

This project is my entry for the LemonWay WebService Challenge.

Building and launching the solution should make a new window appear.
The window consists of two elements : one that gives the nth iteration of the Fibonnaci sequence and the other one is a XML to Json converter.

For both elements the result is shown in a MessageBox as well as in a Textbox in the main window.
For the Fibonnaci sequence part, the exceution as been intentionnally slowed down as requested by the exercise. During the execution, a BusyForm shows up until the method finishes.

Unit test is mocking the WebServce, this cause code duplication and can be resolved by moving the actual calculation out of the webservice class and putting it in a different class.
