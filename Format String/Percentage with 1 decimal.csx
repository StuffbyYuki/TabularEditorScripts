///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This sets a format string of a measure to percentage with 1 decimal          //
///////////////////////////////////////////////////////////////////////////////////////


var formatString = "#,0.0%;-#,0.0%;#,0.0%";

foreach(var c in Selected.Measures)
{
    c.FormatString = formatString;
};