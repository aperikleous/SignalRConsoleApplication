using Npgsql;
using SignalRConsoleEntities;
using System;
using System.Data;

namespace SignalRConsoleDatabase
{
    public class DBConnection
    {
        public DBConnection()
        {
            string connStr = "Server=localhost;Port=5432;User Id=pg;Password=1234q;Database=newdb";
            var connection = new NpgsqlConnection(connStr);
            var tableCreation = new NpgsqlCommand(
               "CREATE TABLE IF NOT EXISTS SensorData" +
               "(Timestamp VARCHAR(256), Id VARCHAR(256) CONSTRAINT Id PRIMARY KEY," +
               "Sensor1 VARCHAR(256), Sensor2 VARCHAR(256), Sensor3 VARCHAR(256), Sensor4 VARCHAR(256), Sensor5 VARCHAR(256), Sensor6 VARCHAR(256), Sensor7 VARCHAR(256), Sensor8 VARCHAR(256), Sensor9 VARCHAR(256), Sensor10 VARCHAR(256)," +
               "Sensor11 VARCHAR(256), Sensor12 VARCHAR(256), Sensor13 VARCHAR(256), Sensor14 VARCHAR(256), Sensor15 VARCHAR(256), Sensor16 VARCHAR(256), Sensor17 VARCHAR(256), Sensor18 VARCHAR(256), Sensor19 VARCHAR(256), Sensor20 VARCHAR(256)," +
               "Sensor21 VARCHAR(256), Sensor22 VARCHAR(256), Sensor23 VARCHAR(256), Sensor24 VARCHAR(256), Sensor25 VARCHAR(256), Sensor26 VARCHAR(256), Sensor27 VARCHAR(256), Sensor28 VARCHAR(256), Sensor29 VARCHAR(256), Sensor30 VARCHAR(256)," +
               "Sensor31 VARCHAR(256), Sensor32 VARCHAR(256), Sensor33 VARCHAR(256), Sensor34 VARCHAR(256), Sensor35 VARCHAR(256), Sensor36 VARCHAR(256), Sensor37 VARCHAR(256), Sensor38 VARCHAR(256), Sensor39 VARCHAR(256), Sensor40 VARCHAR(256)," +
               "Sensor41 VARCHAR(256), Sensor42 VARCHAR(256), Sensor43 VARCHAR(256), Sensor44 VARCHAR(256), Sensor45 VARCHAR(256), Sensor46 VARCHAR(256), Sensor47 VARCHAR(256), Sensor48 VARCHAR(256), Sensor49 VARCHAR(256), Sensor50 VARCHAR(256)," +
               "Sensor51 VARCHAR(256), Sensor52 VARCHAR(256), Sensor53 VARCHAR(256), Sensor54 VARCHAR(256), Sensor55 VARCHAR(256), Sensor56 VARCHAR(256), Sensor57 VARCHAR(256), Sensor58 VARCHAR(256), Sensor59 VARCHAR(256), Sensor60 VARCHAR(256)," +
               "Sensor61 VARCHAR(256), Sensor62 VARCHAR(256), Sensor63 VARCHAR(256), Sensor64 VARCHAR(256), Sensor65 VARCHAR(256), Sensor66 VARCHAR(256), Sensor67 VARCHAR(256), Sensor68 VARCHAR(256), Sensor69 VARCHAR(256), Sensor70 VARCHAR(256)," +
               "Sensor71 VARCHAR(256), Sensor72 VARCHAR(256), Sensor73 VARCHAR(256), Sensor74 VARCHAR(256), Sensor75 VARCHAR(256), Sensor76 VARCHAR(256), Sensor77 VARCHAR(256), Sensor78 VARCHAR(256), Sensor79 VARCHAR(256), Sensor80 VARCHAR(256)," +
               "Sensor81 VARCHAR(256), Sensor82 VARCHAR(256), Sensor83 VARCHAR(256), Sensor84 VARCHAR(256), Sensor85 VARCHAR(256), Sensor86 VARCHAR(256), Sensor87 VARCHAR(256), Sensor88 VARCHAR(256), Sensor89 VARCHAR(256), Sensor90 VARCHAR(256)," +
               "Sensor91 VARCHAR(256), Sensor92 VARCHAR(256), Sensor93 VARCHAR(256), Sensor94 VARCHAR(256), Sensor95 VARCHAR(256), Sensor96 VARCHAR(256), Sensor97 VARCHAR(256), Sensor98 VARCHAR(256), Sensor99 VARCHAR(256), Sensor100 VARCHAR(256)," +
               "Sensor101 VARCHAR(256), Sensor102 VARCHAR(256), Sensor103 VARCHAR(256), Sensor104 VARCHAR(256), Sensor105 VARCHAR(256), Sensor106 VARCHAR(256), Sensor107 VARCHAR(256), Sensor108 VARCHAR(256), Sensor109 VARCHAR(256), Sensor110 VARCHAR(256)," +
               "Sensor111 VARCHAR(256), Sensor112 VARCHAR(256), Sensor113 VARCHAR(256), Sensor114 VARCHAR(256), Sensor115 VARCHAR(256), Sensor116 VARCHAR(256), Sensor117 VARCHAR(256), Sensor118 VARCHAR(256), Sensor119 VARCHAR(256), Sensor120 VARCHAR(256)," +
               "Sensor121 VARCHAR(256), Sensor122 VARCHAR(256), Sensor123 VARCHAR(256), Sensor124 VARCHAR(256), Sensor125 VARCHAR(256), Sensor126 VARCHAR(256), Sensor127 VARCHAR(256), Sensor128 VARCHAR(256), Sensor129 VARCHAR(256), Sensor130 VARCHAR(256)," +
               "Sensor131 VARCHAR(256), Sensor132 VARCHAR(256), Sensor133 VARCHAR(256), Sensor134 VARCHAR(256), Sensor135 VARCHAR(256), Sensor136 VARCHAR(256), Sensor137 VARCHAR(256), Sensor138 VARCHAR(256), Sensor139 VARCHAR(256), Sensor140 VARCHAR(256)," +
               "Sensor141 VARCHAR(256), Sensor142 VARCHAR(256), Sensor143 VARCHAR(256), Sensor144 VARCHAR(256), Sensor145 VARCHAR(256), Sensor146 VARCHAR(256), Sensor147 VARCHAR(256), Sensor148 VARCHAR(256), Sensor149 VARCHAR(256), Sensor150 VARCHAR(256))", connection);
            connection.Open();
            tableCreation.ExecuteNonQuery();
            connection.Close();
        }

        public int StoreSensorData(SensorData sData)
        {
            string connStr = "Server=localhost;Port=5432;User Id=pg;Password=1234q;Database=newdb";
            string query = @"INSERT INTO SensorData (Timestamp, Id, 
                             Sensor1, Sensor2, Sensor3, Sensor4, Sensor5, Sensor6, Sensor7, Sensor8, Sensor9, Sensor10,
                             Sensor11, Sensor12, Sensor13, Sensor14, Sensor15, Sensor16, Sensor17, Sensor18, Sensor19, Sensor20,
                             Sensor21, Sensor22, Sensor23, Sensor24, Sensor25, Sensor26, Sensor27, Sensor28, Sensor29, Sensor30,
                             Sensor31, Sensor32, Sensor33, Sensor34, Sensor35, Sensor36, Sensor37, Sensor38, Sensor39, Sensor40,
                             Sensor41, Sensor42, Sensor43, Sensor44, Sensor45, Sensor46, Sensor47, Sensor48, Sensor49, Sensor50,
                             Sensor51, Sensor52, Sensor53, Sensor54, Sensor55, Sensor56, Sensor57, Sensor58, Sensor59, Sensor60,
                             Sensor61, Sensor62, Sensor63, Sensor64, Sensor65, Sensor66, Sensor67, Sensor68, Sensor69, Sensor70,
                             Sensor71, Sensor72, Sensor73, Sensor74, Sensor75, Sensor76, Sensor77, Sensor78, Sensor79, Sensor80,
                             Sensor81, Sensor82, Sensor83, Sensor84, Sensor85, Sensor86, Sensor87, Sensor88, Sensor89, Sensor90,
                             Sensor91, Sensor92, Sensor93, Sensor94, Sensor95, Sensor96, Sensor97, Sensor98, Sensor99, Sensor100,
                             Sensor101, Sensor102, Sensor103, Sensor104, Sensor105, Sensor106, Sensor107, Sensor108, Sensor109, Sensor110,
                             Sensor111, Sensor112, Sensor113, Sensor114, Sensor115, Sensor116, Sensor117, Sensor118, Sensor119, Sensor120,
                             Sensor121, Sensor122, Sensor123, Sensor124, Sensor125, Sensor126, Sensor127, Sensor128, Sensor129, Sensor130,
                             Sensor131, Sensor132, Sensor133, Sensor134, Sensor135, Sensor136, Sensor137, Sensor138, Sensor139, Sensor140,
                             Sensor141, Sensor142, Sensor143, Sensor144, Sensor145, Sensor146, Sensor147, Sensor148, Sensor149, Sensor150) 
                             VALUES (@Timestamp, @Id, 
                             @Sensor1, @Sensor2, @Sensor3, @Sensor4, @Sensor5, @Sensor6, @Sensor7, @Sensor8, @Sensor9, @Sensor10,
                             @Sensor11, @Sensor12, @Sensor13, @Sensor14, @Sensor15, @Sensor16, @Sensor17, @Sensor18, @Sensor19, @Sensor20,
                             @Sensor21, @Sensor22, @Sensor23, @Sensor24, @Sensor25, @Sensor26, @Sensor27, @Sensor28, @Sensor29, @Sensor30,
                             @Sensor31, @Sensor32, @Sensor33, @Sensor34, @Sensor35, @Sensor36, @Sensor37, @Sensor38, @Sensor39, @Sensor40,
                             @Sensor41, @Sensor42, @Sensor43, @Sensor44, @Sensor45, @Sensor46, @Sensor47, @Sensor48, @Sensor49, @Sensor50,
                             @Sensor51, @Sensor52, @Sensor53, @Sensor54, @Sensor55, @Sensor56, @Sensor57, @Sensor58, @Sensor59, @Sensor60,
                             @Sensor61, @Sensor62, @Sensor63, @Sensor64, @Sensor65, @Sensor66, @Sensor67, @Sensor68, @Sensor69, @Sensor70,
                             @Sensor71, @Sensor72, @Sensor73, @Sensor74, @Sensor75, @Sensor76, @Sensor77, @Sensor78, @Sensor79, @Sensor80,
                             @Sensor81, @Sensor82, @Sensor83, @Sensor84, @Sensor85, @Sensor86, @Sensor87, @Sensor88, @Sensor89, @Sensor90,
                             @Sensor91, @Sensor92, @Sensor93, @Sensor94, @Sensor95, @Sensor96, @Sensor97, @Sensor98, @Sensor99, @Sensor100,
                             @Sensor101, @Sensor102, @Sensor103, @Sensor104, @Sensor105, @Sensor106, @Sensor107, @Sensor108, @Sensor109, @Sensor110,
                             @Sensor111, @Sensor112, @Sensor113, @Sensor114, @Sensor115, @Sensor116, @Sensor117, @Sensor118, @Sensor119, @Sensor120,
                             @Sensor121, @Sensor122, @Sensor123, @Sensor124, @Sensor125, @Sensor126, @Sensor127, @Sensor128, @Sensor129, @Sensor130,
                             @Sensor131, @Sensor132, @Sensor133, @Sensor134, @Sensor135, @Sensor136, @Sensor137, @Sensor138, @Sensor139, @Sensor140,
                             @Sensor141, @Sensor142, @Sensor143, @Sensor144, @Sensor145, @Sensor146, @Sensor147, @Sensor148, @Sensor149, @Sensor150)";
            using (NpgsqlConnection con = new NpgsqlConnection(connStr))
            {
                string val = "";
                con.Open();
                using (NpgsqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Timestamp", sData.Timestamp);
                    cmd.Parameters.AddWithValue("@Id", sData.Id);
                    for (int i = 1; i <= 150; i++)
                    {
                        if (sData.Data.TryGetValue("Sensor" + i, out val))
                            cmd.Parameters.AddWithValue("@Sensor" + i, sData.Data["Sensor" + i]);
                        else
                            cmd.Parameters.AddWithValue("@Sensor" + i, DBNull.Value);
                    }

                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
