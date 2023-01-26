///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script goes through all selected columns and hide them                  //
///////////////////////////////////////////////////////////////////////////////////////


foreach(var c in Selected.Columns)
{
    c.IsHidden = true;
};
