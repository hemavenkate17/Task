using System;
using System.Data;
using System.Data.SqlClient;


namespace AdoExampleProject
{
    class Program
    {
        string conString;
        SqlConnection con;
        SqlCommand cmd;

     

    public Program()
        {
            conString = @"server=LAPTOP-FUHQ3D30\SQLEXPRESS;Integrated security=true;Initial catalog=pubs";
            con = new SqlConnection(conString);
        }

        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print all the movies");
                Console.WriteLine("2. fetch one movie from Database");
                Console.WriteLine("3. Add movie details");
                Console.WriteLine("4. update movie duration");
                Console.WriteLine("5. Delete movie details");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintMovie();
                        break;
                    case 2:
                        FetchOneMoviesFromDatabase();
                        break;
                    case 3:
                        AddMovie();
                        break;
                    case 4:
                        UpdateMovieDuration();
                        break;
                    case 5:
                        DeleteMovie();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 6);
        }
       void PrintMovie()
        {
            string strcmd = "select* from tblMovie";
            cmd = new SqlCommand(strcmd, con);
            try
            {
                con.Open();
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id " + drMovies[0].ToString());
                    Console.WriteLine("Movie Name " + drMovies[1]);
                    Console.WriteLine("Movie Duration " + drMovies[2].ToString());
                    Console.WriteLine("----------------");

                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void FetchOneMoviesFromDatabase()
        {
            string strcmd = "select* from tblMovie where id = @mid";
            cmd = new SqlCommand(strcmd, con);
            try
            {
                con.Open();
                Console.WriteLine("Please enter the id");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.Add("@mid",SqlDbType.Int);
                cmd.Parameters[0].Value = id;
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id" + " "+ drMovies[0].ToString());
                    Console.WriteLine("Movie Name" + " " + drMovies[1]);
                    Console.WriteLine("Movie Duration" + " " + drMovies[2].ToString());
                    Console.WriteLine("----------------");

                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void AddMovie()
        {
            Console.WriteLine("enter the movie name");
            string mName = Console.ReadLine();
            Console.WriteLine("enter movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "insert into tblMovie(name,duration) values(@mname,@mdur)";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mname", mName);
            cmd.Parameters.AddWithValue("@mdur", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Movie inserted into the Database");
                else
                    Console.WriteLine("No not done");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void UpdateMovieDuration()
        {
            
            Console.WriteLine("Please enter the movie Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "Update tblMovie set duration = @mduration where id = @mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            cmd.Parameters.AddWithValue("@mduration", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Movie details Updated");
                else
                    Console.WriteLine("No not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

       
        void DeleteMovie()
        {
            Console.WriteLine("Please enter the movie name");
            string mName= Console.ReadLine();
            Console.WriteLine("Please enter the movie Duration");
            string mDuration = Console.ReadLine();
            string strCmd = "Delete from tblMovie where name=@mName";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mname", mName);
            cmd.Parameters.AddWithValue("@mduration", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Movie Details deleted from the Database");
                else
                    Console.WriteLine("no not done");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
            static void Main(string[] args)
            {
                
                Program program = new Program();
                program.PrintMenu();
                program.AddMovie();
                program.FetchOneMoviesFromDatabase();
                program.UpdateMovieDuration();
                program.DeleteMovie();
                Console.ReadKey();
            }

        
    }
}
