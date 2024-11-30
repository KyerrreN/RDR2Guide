using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RDR2Guide.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<byte>(type: "tinyint", nullable: false),
                    Reward = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Miscellaneous",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miscellaneous", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tablegames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablegames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Randomencounters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randomencounters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randomencounters_Factions_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hostility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLegendary = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bait = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLegendary = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fish_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Health = table.Column<byte>(type: "tinyint", nullable: false),
                    Stamina = table.Column<byte>(type: "tinyint", nullable: false),
                    Speed = table.Column<byte>(type: "tinyint", nullable: false),
                    Acceleration = table.Column<byte>(type: "tinyint", nullable: false),
                    Handling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horses_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEdible = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sidequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestGiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMissable = table.Column<bool>(type: "bit", nullable: false),
                    MissableChapter = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sidequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sidequests_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storyquests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storyquests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storyquests_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<float>(type: "real", nullable: false),
                    Range = table.Column<float>(type: "real", nullable: false),
                    FiringRate = table.Column<float>(type: "real", nullable: false),
                    Accuracy = table.Column<float>(type: "real", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: true),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeUser",
                columns: table => new
                {
                    ChallengesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeUser", x => new { x.ChallengesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ChallengeUser_Challenges_ChallengesId",
                        column: x => x.ChallengesId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengeUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactionUser",
                columns: table => new
                {
                    FactionsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactionUser", x => new { x.FactionsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_FactionUser_Factions_FactionsId",
                        column: x => x.FactionsId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactionUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiscellaneousUser",
                columns: table => new
                {
                    MiscellaneousId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscellaneousUser", x => new { x.MiscellaneousId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MiscellaneousUser_Miscellaneous_MiscellaneousId",
                        column: x => x.MiscellaneousId,
                        principalTable: "Miscellaneous",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiscellaneousUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablegameUser",
                columns: table => new
                {
                    TablegamesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablegameUser", x => new { x.TablegamesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TablegameUser_Tablegames_TablegamesId",
                        column: x => x.TablegamesId,
                        principalTable: "Tablegames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TablegameUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserChallenges",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChallengeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChallenges", x => new { x.UserId, x.ChallengeId });
                    table.ForeignKey(
                        name: "FK_UserChallenges_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChallenges_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFactions",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFactions", x => new { x.UserId, x.FactionId });
                    table.ForeignKey(
                        name: "FK_UserFactions_Factions_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMiscellaneous",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MiscellaneousId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMiscellaneous", x => new { x.UserId, x.MiscellaneousId });
                    table.ForeignKey(
                        name: "FK_UserMiscellaneous_Miscellaneous_MiscellaneousId",
                        column: x => x.MiscellaneousId,
                        principalTable: "Miscellaneous",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMiscellaneous_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTablegames",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TablegameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTablegames", x => new { x.UserId, x.TablegameId });
                    table.ForeignKey(
                        name: "FK_UserTablegames_Tablegames_TablegameId",
                        column: x => x.TablegameId,
                        principalTable: "Tablegames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTablegames_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RandomencounterUser",
                columns: table => new
                {
                    RandomencountersId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandomencounterUser", x => new { x.RandomencountersId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RandomencounterUser_Randomencounters_RandomencountersId",
                        column: x => x.RandomencountersId,
                        principalTable: "Randomencounters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RandomencounterUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRandomencounters",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RandomencounterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRandomencounters", x => new { x.UserId, x.RandomencounterId });
                    table.ForeignKey(
                        name: "FK_UserRandomencounters_Randomencounters_RandomencounterId",
                        column: x => x.RandomencounterId,
                        principalTable: "Randomencounters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRandomencounters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalUser",
                columns: table => new
                {
                    AnimalsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalUser", x => new { x.AnimalsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AnimalUser_Animals_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnimals",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimals", x => new { x.UserId, x.AnimalId });
                    table.ForeignKey(
                        name: "FK_UserAnimals_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FishUser",
                columns: table => new
                {
                    FishId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishUser", x => new { x.FishId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_FishUser_Fish_FishId",
                        column: x => x.FishId,
                        principalTable: "Fish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFish",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFish", x => new { x.UserId, x.FishId });
                    table.ForeignKey(
                        name: "FK_UserFish_Fish_FishId",
                        column: x => x.FishId,
                        principalTable: "Fish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFish_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorseUser",
                columns: table => new
                {
                    HorsesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorseUser", x => new { x.HorsesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_HorseUser_Horses_HorsesId",
                        column: x => x.HorsesId,
                        principalTable: "Horses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorseUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHorses",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    HorseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHorses", x => new { x.UserId, x.HorseId });
                    table.ForeignKey(
                        name: "FK_UserHorses_Horses_HorseId",
                        column: x => x.HorseId,
                        principalTable: "Horses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHorses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantUser",
                columns: table => new
                {
                    PlantsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantUser", x => new { x.PlantsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PlantUser_Plants_PlantsId",
                        column: x => x.PlantsId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPlants",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PlantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlants", x => new { x.UserId, x.PlantId });
                    table.ForeignKey(
                        name: "FK_UserPlants_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collectibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<byte>(type: "tinyint", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SidequestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collectibles_Sidequests_SidequestId",
                        column: x => x.SidequestId,
                        principalTable: "Sidequests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SidequestUser",
                columns: table => new
                {
                    SidequestsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SidequestUser", x => new { x.SidequestsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_SidequestUser_Sidequests_SidequestsId",
                        column: x => x.SidequestsId,
                        principalTable: "Sidequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SidequestUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSidequests",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SidequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSidequests", x => new { x.UserId, x.SidequestId });
                    table.ForeignKey(
                        name: "FK_UserSidequests_Sidequests_SidequestId",
                        column: x => x.SidequestId,
                        principalTable: "Sidequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSidequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoryquestUser",
                columns: table => new
                {
                    StoryquestsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryquestUser", x => new { x.StoryquestsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_StoryquestUser_Storyquests_StoryquestsId",
                        column: x => x.StoryquestsId,
                        principalTable: "Storyquests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoryquestUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserStoryquests",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StoryquestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStoryquests", x => new { x.UserId, x.StoryquestId });
                    table.ForeignKey(
                        name: "FK_UserStoryquests_Storyquests_StoryquestId",
                        column: x => x.StoryquestId,
                        principalTable: "Storyquests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserStoryquests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWeapon",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWeapon", x => new { x.UsersId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_UserWeapon_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWeapon_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWeapons",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWeapons", x => new { x.UserId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_UserWeapons_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWeapons_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectibleUser",
                columns: table => new
                {
                    CollectiblesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectibleUser", x => new { x.CollectiblesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CollectibleUser_Collectibles_CollectiblesId",
                        column: x => x.CollectiblesId,
                        principalTable: "Collectibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectibleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCollectibles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CollectibleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCollectibles", x => new { x.UserId, x.CollectibleId });
                    table.ForeignKey(
                        name: "FK_UserCollectibles_Collectibles_CollectibleId",
                        column: x => x.CollectibleId,
                        principalTable: "Collectibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCollectibles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "Description", "Name", "Rank", "Reward" },
                values: new object[,]
                {
                    { 1, "Hold up 5 townsfolk.", "Bandit", (byte)1, "Bandit Bandolier" },
                    { 2, "Rob any 2 coaches or return any 2 stolen coaches to the Fence.", "Bandit", (byte)2, "25 Dead Eye XP, $5.00" },
                    { 3, "Win 5 hands of poker.", "Gambler", (byte)1, "Gambler Holster" },
                    { 4, "Win 3 gameы of Five Finger Fillet.", "Gambler", (byte)3, "Gambler Bandolier" },
                    { 5, "Catch 3 Bluegill fish.", "Survivalist", (byte)1, "Survivalist Gun Belt" },
                    { 6, "Find a treasure map.", "Explorer", (byte)1, "Explorer Holster" },
                    { 7, "Jump over 3 obstacles in 15 seconds.", "Horseman", (byte)2, "25 Stamina XP, $5.00" },
                    { 8, "Track 10 different animal species using your binoculars.", "Master Hunter", (byte)3, "Master Hunter Bandolier" },
                    { 9, "Kill 3 enemies with a knife.", "Weapons Expert", (byte)1, "Weapons Expert Holster" },
                    { 10, "Pick one of each species of herb.", "Herbalist", (byte)9, "150 Health XP, $20.00" }
                });

            migrationBuilder.InsertData(
                table: "Collectibles",
                columns: new[] { "Id", "Amount", "Image", "Name", "SidequestId" },
                values: new object[,]
                {
                    { 4, (byte)9, null, "Graves of your fallen companions", null },
                    { 5, (byte)10, null, "Fish species", null },
                    { 6, (byte)5, null, "Hunting requests", null },
                    { 7, (byte)20, null, "Dreamcatchers", null },
                    { 8, (byte)48, null, "Weapons", null },
                    { 9, (byte)20, null, "Plant species", null },
                    { 10, (byte)6, null, "Gangs", null }
                });

            migrationBuilder.InsertData(
                table: "Factions",
                columns: new[] { "Id", "Leader", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Colm O'Driscoll", "O'Driscoll Boys", "Disbanded" },
                    { 2, "Lindsey Wofford", "Lemoyne Raiders", "Active" },
                    { 3, "Otis Skinner", "Skinner Brothers", "Active" },
                    { 4, "Walt Murfree", "Murfree Brood", "Active" },
                    { 5, "Laramie Gang Leader", "Laramie Gang", "Active" },
                    { 6, "Esteban Cortez", "Del Lobo Gang", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Horses",
                columns: new[] { "Id", "Acceleration", "Breed", "Handling", "Health", "Image", "LocationId", "Speed", "Stamina" },
                values: new object[] { 6, (byte)3, "Ardennes", "Standard", (byte)5, null, 14, (byte)3, (byte)4 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, null, "Valentine" },
                    { 2, null, "Strawberry" },
                    { 3, null, "New Hanover" },
                    { 4, null, "West Elizabeth" },
                    { 5, null, "Scarlett Meadows" },
                    { 6, null, "Bayou Nwa" },
                    { 7, null, "Tumbleweed" },
                    { 8, null, "Blackwater" },
                    { 9, null, "Colter" },
                    { 10, null, "Horseshoe Overlook" },
                    { 11, null, "Cornwall Kerosene&Tar" },
                    { 12, null, "Ambarino" },
                    { 13, null, "Saint Denis" },
                    { 15, null, "New Austin" },
                    { 16, null, "Guarma island" }
                });

            migrationBuilder.InsertData(
                table: "Miscellaneous",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Investigate any 5 shacks." },
                    { 2, "Kill any 5 Legendary Animals." },
                    { 3, "Play each table game at least once." },
                    { 4, "Interact with 5 special characters." },
                    { 5, "Take a bath at least once. (Available in hotels)" },
                    { 6, "Watch a show." },
                    { 7, "Watch a live show at the Theater." },
                    { 8, "Craft 1 recipe from six different category types." },
                    { 9, "Complete a Home Robbery, a Shop Robbery, a Coach Robbery and a Train Robbery." }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Image", "IsEdible", "LocationId", "Name" },
                values: new object[] { 4, null, false, 14, "Hummingbird Sage" });

            migrationBuilder.InsertData(
                table: "Sidequests",
                columns: new[] { "Id", "Image", "IsMissable", "LocationId", "MissableChapter", "Name", "QuestGiver", "Reward" },
                values: new object[] { 8, null, false, 14, null, "He's British, of Course", "Margaret", "Emerald" });

            migrationBuilder.InsertData(
                table: "Tablegames",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The player can participate in games of poker throughout the game world. Poker is often used as a money-making method, but the process is a risk as you can either lose or earn considerable sums of cash. Saloons prominently feature poker tables.\r\n\r\nThe poker rules used in-game are those from no-limit Texas Hold 'Em. You should have at least a passing understanding of the rules as the game does not tell you all of the information on a winning hand, only the primary information. Winning hands (in order from worst to best) are as follows: High card, 1 pair, 2 pairs, 3 of a kind, straight (five cards in sequence such as 9-10-Jack-Queen-King), flush (5 of one suit), full house (three of a kind plus a pair), four of a kind, straight flush (5 sequential cards of the same suit), royal flush (as with straight flush but 10, Jack, Queen, King, Ace).\r\n\r\nPlayers may use any combination of the two cards they hold and the five community cards to form the best five-card hand. The nature of community-card poker games greatly increases the chance of two or more players each having strong hands, thus increasing the level of action (betting).", "Poker" },
                    { 2, "Blackjack is a type of card game, and is traditionally associated with betting and gambling. It is also known colloquially as Twenty-One and Pontoon. In North America during the early twentieth-century time period that Red Dead Redemption is set in, blackjack is a serious parlor game that can sometimes result in violent disputes and death.", "Blackjack" },
                    { 3, "To play, the player places their hand palm-down on a table with his fingers spread apart. Using a knife, the player attempts to quickly strike the spaces between his fingers, while moving the knife back and forth, attempting to avoid injury. The higher the wager the user chooses the harder the pattern will be. The knife seems to be a larger version of the Throwing Knife.\r\n\r\nThis game is played competitively and cash is wagered on the outcome. The difficulty of the game increases with larger bets.", "Five Finger Fillet" },
                    { 4, "The goal is to empty your hand of dominoes first. It is done by placing dominoes with matching pips together. If a domino cannot be played, the player must draw from the \"boneyard\" until a playable domino is drawn. The first person to run out, wins.", "Dominoes" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Hostility", "Image", "IsLegendary", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, "Friendly", null, false, 1, "American Domestic Cat" },
                    { 2, "Enemy", null, false, 3, "Cougar" },
                    { 3, "Neutral", null, false, 3, "California Valley Coyote" },
                    { 4, "Neutral", null, false, 3, "Bison" },
                    { 5, "Neutral", null, false, 3, "Black-tailed Jackrabbit" },
                    { 6, "Neutral", null, false, 3, "American Fox" },
                    { 7, "Neutral", null, false, 3, "American Pronghorn Doe" },
                    { 8, "Neutral", null, false, 3, "American Red Fox" },
                    { 9, "Enemy", null, false, 12, "American Black Bear" },
                    { 10, "Neutral", null, false, 12, "American Crow" }
                });

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "Bait", "IsLegendary", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, "Cheese", false, 4, "Bluegill" },
                    { 2, "Crayfish", false, 6, "Largemouth Bass" },
                    { 3, "Special Lake Lure", true, 5, "Legendary Bluegill" }
                });

            migrationBuilder.InsertData(
                table: "Horses",
                columns: new[] { "Id", "Acceleration", "Breed", "Handling", "Health", "Image", "LocationId", "Speed", "Stamina" },
                values: new object[,]
                {
                    { 1, (byte)4, "American Paint", "Standard", (byte)5, null, 7, (byte)4, (byte)5 },
                    { 2, (byte)4, "American Standardbred", "Race", (byte)3, null, 1, (byte)5, (byte)3 },
                    { 3, (byte)6, "Arabian", "Elite", (byte)6, null, 8, (byte)6, (byte)6 },
                    { 4, (byte)5, "Turkoman", "Standard", (byte)7, null, 8, (byte)6, (byte)5 },
                    { 5, (byte)3, "Appaloosa", "Standard", (byte)3, null, 12, (byte)3, (byte)4 },
                    { 7, (byte)3, "Belgian Draft Horse", "Heavy", (byte)3, null, 1, (byte)3, (byte)3 },
                    { 8, (byte)3, "Dutch Warmblood", "Standard", (byte)5, null, 1, (byte)4, (byte)6 },
                    { 9, (byte)3, "Hungarian Half-bred", "Standard", (byte)5, null, 4, (byte)3, (byte)4 },
                    { 10, (byte)2, "Kentucky Saddler", "Standard", (byte)3, null, 12, (byte)3, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Image", "IsEdible", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, null, true, 4, "Alaskan Ginseng" },
                    { 2, null, false, 6, "Oleander Sage" },
                    { 3, null, true, 3, "American Ginseng" },
                    { 5, null, false, 4, "Golden Currant" },
                    { 6, null, false, 12, "English Mace" },
                    { 7, null, true, 15, "Desert Sage" },
                    { 8, null, false, 6, "Common Bulrush" },
                    { 9, null, false, 12, "Blackcurrant" },
                    { 10, null, true, 4, "Burdock Root" }
                });

            migrationBuilder.InsertData(
                table: "Randomencounters",
                columns: new[] { "Id", "FactionId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Stagecoach Robbery" },
                    { 2, 2, "Gatling Gun Ambush" },
                    { 3, 2, "Arson and Vandalism at the Saint Denis City Hall" },
                    { 4, 4, "Camp Intimidation" },
                    { 5, 4, "Burning Wagon Attack" },
                    { 6, 5, "Hostage Situation" },
                    { 7, 6, "Venter's Place Party" },
                    { 8, 6, "Del Lobo Breakout" },
                    { 9, 1, "Train Robbery" },
                    { 10, 1, "Prison Wagon Break" }
                });

            migrationBuilder.InsertData(
                table: "Sidequests",
                columns: new[] { "Id", "Image", "IsMissable", "LocationId", "MissableChapter", "Name", "QuestGiver", "Reward" },
                values: new object[,]
                {
                    { 1, null, false, 1, null, "Smoking and other Hobbies", "Phineas T. Ramsbottom", "Vintage Civil War Handcuffs" },
                    { 2, null, false, 2, null, "Geology for Beginners", "Francis Sinclair", "Rock Statue" },
                    { 3, null, false, 1, null, "A Test of Faith", "Deborah MacGuiness", "Quartz Chunk" },
                    { 4, null, false, 1, null, "The Noblest of Men, and a Woman", "Theodore Levin", "Letter from Theodore Levin, $350" },
                    { 5, null, false, 3, null, "The Smell of the Grease Paint", "Miss Marjorie", "Letter from Miss Marjorie, $40" },
                    { 6, null, false, 5, null, "The Iniquities of History", "Jeremiah Compson", "Honor" },
                    { 7, null, false, 5, null, "The Ties That Bind Us", "Sampson Black & Wendell White", "$40 or Positive Honor" },
                    { 9, null, false, 13, null, "The Artist's Way", "Charles Chatenay", "Missable Otis Miller's Revolver" },
                    { 10, null, false, 13, null, "Duchesses and Other Animals", "Algernon Wasp", "$750, Exotic Hat, Algernon's Revolver" }
                });

            migrationBuilder.InsertData(
                table: "Storyquests",
                columns: new[] { "Id", "Image", "LocationId", "Name", "Number", "Reward" },
                values: new object[,]
                {
                    { 1, null, 9, "Outlaws from the West", 1, "Mahogany Boy Tennessee Walker" },
                    { 2, null, 10, "Pouring Forth Oil I", 1, null },
                    { 3, null, 11, "Pouring Forth Oil II", 2, null },
                    { 4, null, 13, "Angelo Bronte, A Man of Honor", 1, null },
                    { 5, null, 13, "Help a Brother Out", 1, "$1.00 (Optional)" },
                    { 6, null, 16, "Hell Hath No Fury", 1, null },
                    { 7, null, 16, "Paradise Mercifully Departed", 1, null },
                    { 8, null, 3, "Dear Uncle Tacitus", 1, null },
                    { 9, null, 3, "That's Murfree Country", 1, "Mauser Pistol available in gunsmiths, Unlocks Legendary Bullgator" },
                    { 10, null, 13, "A Fork in the Road", 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserChallenges",
                columns: new[] { "ChallengeId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserCollectibles",
                columns: new[] { "CollectibleId", "UserId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserFactions",
                columns: new[] { "FactionId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserFish",
                columns: new[] { "FishId", "UserId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserMiscellaneous",
                columns: new[] { "MiscellaneousId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserPlants",
                columns: new[] { "PlantId", "UserId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "UserTablegames",
                columns: new[] { "TablegameId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Accuracy", "Cost", "Damage", "FiringRate", "Image", "IsUnique", "LocationId", "Name", "Range" },
                values: new object[,]
                {
                    { 1, 2.8f, 50, 1.7f, 3f, null, false, 1, "Cattleman Revolver", 2f },
                    { 2, 2.8f, null, 1.7f, 3f, null, true, 2, "Granger's Revolver", 2f },
                    { 3, 3f, 84, 1.9f, 2.8f, null, false, 1, "Schofield Revolver", 2f },
                    { 4, 2.8f, null, 1.7f, 3f, null, true, 12, "Flaco's Revolver", 2f },
                    { 5, 2f, 65, 1.5f, 3.2f, null, false, 1, "Double-action Revolver", 2f },
                    { 6, 2.8f, 190, 1.5f, 3.2f, null, false, 1, "High Roller Double-Action Revolver", 2f },
                    { 7, 3.2f, 350, 1.5f, 3.1f, null, false, 13, "M1899 Pistol", 2f },
                    { 8, 3f, 140, 2f, 2.6f, null, false, 1, "Evans Repeater", 2.6f },
                    { 9, 2.7f, 145, 2.8f, 2.2f, null, false, 1, "Litchfield Repeater", 2.8f },
                    { 10, 1.8f, 95, 2.8f, 2.5f, null, false, 1, "Double-barreled Shotgun", 1.5f }
                });

            migrationBuilder.InsertData(
                table: "Collectibles",
                columns: new[] { "Id", "Amount", "Image", "Name", "SidequestId" },
                values: new object[,]
                {
                    { 1, (byte)144, null, "Cigarette Cards", 1 },
                    { 2, (byte)10, null, "Rock Carvings", 2 },
                    { 3, (byte)30, null, "Dinosaur Bones", 3 }
                });

            migrationBuilder.InsertData(
                table: "UserAnimals",
                columns: new[] { "AnimalId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 2, 3 },
                    { 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserFish",
                columns: new[] { "FishId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserHorses",
                columns: new[] { "HorseId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserPlants",
                columns: new[] { "PlantId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserRandomencounters",
                columns: new[] { "RandomencounterId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserSidequests",
                columns: new[] { "SidequestId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserStoryquests",
                columns: new[] { "StoryquestId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserWeapons",
                columns: new[] { "UserId", "WeaponId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserCollectibles",
                columns: new[] { "CollectibleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_LocationId",
                table: "Animals",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalUser_UsersId",
                table: "AnimalUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeUser_UsersId",
                table: "ChallengeUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Collectibles_SidequestId",
                table: "Collectibles",
                column: "SidequestId",
                unique: true,
                filter: "[SidequestId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CollectibleUser_UsersId",
                table: "CollectibleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_FactionUser_UsersId",
                table: "FactionUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Fish_LocationId",
                table: "Fish",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_FishUser_UsersId",
                table: "FishUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Horses_LocationId",
                table: "Horses",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_HorseUser_UsersId",
                table: "HorseUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_MiscellaneousUser_UsersId",
                table: "MiscellaneousUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_LocationId",
                table: "Plants",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantUser_UsersId",
                table: "PlantUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Randomencounters_FactionId",
                table: "Randomencounters",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_RandomencounterUser_UsersId",
                table: "RandomencounterUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sidequests_LocationId",
                table: "Sidequests",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SidequestUser_UsersId",
                table: "SidequestUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Storyquests_LocationId",
                table: "Storyquests",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryquestUser_UsersId",
                table: "StoryquestUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TablegameUser_UsersId",
                table: "TablegameUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_AnimalId",
                table: "UserAnimals",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChallenges_ChallengeId",
                table: "UserChallenges",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCollectibles_CollectibleId",
                table: "UserCollectibles",
                column: "CollectibleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFactions_FactionId",
                table: "UserFactions",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFish_FishId",
                table: "UserFish",
                column: "FishId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHorses_HorseId",
                table: "UserHorses",
                column: "HorseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMiscellaneous_MiscellaneousId",
                table: "UserMiscellaneous",
                column: "MiscellaneousId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlants_PlantId",
                table: "UserPlants",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRandomencounters_RandomencounterId",
                table: "UserRandomencounters",
                column: "RandomencounterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSidequests_SidequestId",
                table: "UserSidequests",
                column: "SidequestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStoryquests_StoryquestId",
                table: "UserStoryquests",
                column: "StoryquestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTablegames_TablegameId",
                table: "UserTablegames",
                column: "TablegameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeapon_WeaponsId",
                table: "UserWeapon",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeapons_WeaponId",
                table: "UserWeapons",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_LocationId",
                table: "Weapons",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalUser");

            migrationBuilder.DropTable(
                name: "ChallengeUser");

            migrationBuilder.DropTable(
                name: "CollectibleUser");

            migrationBuilder.DropTable(
                name: "FactionUser");

            migrationBuilder.DropTable(
                name: "FishUser");

            migrationBuilder.DropTable(
                name: "HorseUser");

            migrationBuilder.DropTable(
                name: "MiscellaneousUser");

            migrationBuilder.DropTable(
                name: "PlantUser");

            migrationBuilder.DropTable(
                name: "RandomencounterUser");

            migrationBuilder.DropTable(
                name: "SidequestUser");

            migrationBuilder.DropTable(
                name: "StoryquestUser");

            migrationBuilder.DropTable(
                name: "TablegameUser");

            migrationBuilder.DropTable(
                name: "UserAnimals");

            migrationBuilder.DropTable(
                name: "UserChallenges");

            migrationBuilder.DropTable(
                name: "UserCollectibles");

            migrationBuilder.DropTable(
                name: "UserFactions");

            migrationBuilder.DropTable(
                name: "UserFish");

            migrationBuilder.DropTable(
                name: "UserHorses");

            migrationBuilder.DropTable(
                name: "UserMiscellaneous");

            migrationBuilder.DropTable(
                name: "UserPlants");

            migrationBuilder.DropTable(
                name: "UserRandomencounters");

            migrationBuilder.DropTable(
                name: "UserSidequests");

            migrationBuilder.DropTable(
                name: "UserStoryquests");

            migrationBuilder.DropTable(
                name: "UserTablegames");

            migrationBuilder.DropTable(
                name: "UserWeapon");

            migrationBuilder.DropTable(
                name: "UserWeapons");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Collectibles");

            migrationBuilder.DropTable(
                name: "Fish");

            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropTable(
                name: "Miscellaneous");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Randomencounters");

            migrationBuilder.DropTable(
                name: "Storyquests");

            migrationBuilder.DropTable(
                name: "Tablegames");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Sidequests");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
