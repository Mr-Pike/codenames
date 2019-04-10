﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeNames.Data.Migrations
{
    public partial class CreateViewGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW ViewGames
                                AS
                                SELECT GW.GameId, GW.WordId, GW.TeamId, GW.order, GW.Find, W.name AS WordName, T.Color AS ColorName
                                FROM GamesWords GW
                                INNER JOIN Words W ON GW.WordId = W.Id
                                INNER JOIN Teams T ON GW.TeamId = T.Id", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS ViewGames", true);
        }
    }
}
