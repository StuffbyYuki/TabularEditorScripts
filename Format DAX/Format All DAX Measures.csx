///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This will go through all the DAX measures and format them all at once        //
// Reference:                                                                        //
//      https://docs.tabulareditor.com/te2/FormatDax.html                            //
///////////////////////////////////////////////////////////////////////////////////////

foreach (var m in Model.AllMeasures) 
{
    m.FormatDax();
}
