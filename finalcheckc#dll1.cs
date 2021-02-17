using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCruiser.Model
{
   public class Movie
    {
        int id;

       

        public  int  Id
        {
            get { return id; }
            set { id = value; }
        }



        string title;
public string Title
{
    get { return title; }
    set { title = value; }
}
        long boxOffice;
public long BoxOffice
{
    get { return boxOffice; }
    set { boxOffice = value; }
}
String active;
public String Active
{
    get { return active; }
    set { active = value; }
}
string dateOfLaunch;
public string DateOfLaunch

{
    get { return dateOfLaunch; }
    set { dateOfLaunch = value; }
}
string genre;
public string Genre
{
    get { return genre; }
    set { genre = value; }
}
string hasTeaser;
public string HasTeaser
{
    get { return hasTeaser; }
    set { hasTeaser = value; }
}


public Movie() { }
public Movie(int Id,string Title,long BoxOffice,string Active,string DateOfLaunch,string Genre,string HasTeaser )
{
    this.Id = id;
    this.Title = title;
    this.BoxOffice = boxOffice;
    this.Active = active;
    this.DateOfLaunch = dateOfLaunch;
    this.Genre = genre;
    this.HasTeaser = hasTeaser;
}
}
}



    

