///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This will go through all selected DAX measures and format them all at once   //
// Reference:                                                                        //
//      https://docs.tabulareditor.com/te2/FormatDax.html                            //
///////////////////////////////////////////////////////////////////////////////////////

foreach (var m in Selected.Measures) 
{
    m.FormatDax();
}
