///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script goes through all the visible columns in the model                //
//      and set IsAvailableInMDX property to false                                   //
///////////////////////////////////////////////////////////////////////////////////////


foreach(var column in Model.AllColumns.Where(c => c.IsHidden))
{
    column.IsAvailableInMDX = false;
};




