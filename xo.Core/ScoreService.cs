using xo.Data;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using xo.Core.Models;

namespace xo.Core
{
    public class ScoreService
    {
        public static string connectionString = "Server=.;Database=xoGame;Trusted_Connection=True;TrustServerCertificate=True";
        public static DataTable Select()
        {
            DataTable dt = new DataTable();
            string selectCmd = "SELECT GameId, PlayerOne, PlayerOneScore, PlayerTwo, PlayerTwoScore, Date FROM dbo.score";
            dt = DbContext.Select(selectCmd, connectionString);
            return dt;
        }

        public static int Delete(int id)
        {
            string deleteCommand = $"DELETE FROM dbo.score WHERE GameId = {id}";

            int result = DbContext.ExecuteNonQuery(deleteCommand, connectionString);
            return result;
        }

        public static int Insert(Game game)
        {
            string InsertCommand = $"INSERT INTO dbo.score (PlayerOne, PlayerOneScore, PlayerTwo, PlayerTwoScore, Date) VALUES ('{game.PlayerOne}', {game.PlayerOneScore}, '{game.PlayerTwo}', {game.PlayerTwoScore}, GETDATE())";

            int result = DbContext.ExecuteNonQuery(InsertCommand, connectionString);
            return result;
        }
    }
}
