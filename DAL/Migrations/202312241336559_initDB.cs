namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        GuestID = c.Int(nullable: false),
                        CheckinTime = c.DateTime(nullable: false),
                        CheckoutTime = c.DateTime(nullable: false),
                        TotalPrice = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Guests", t => t.GuestID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID)
                .Index(t => t.GuestID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        BookingID = c.Int(nullable: false),
                        Amount = c.String(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentMethod = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentID)
                .ForeignKey("dbo.Bookings", t => t.BookingID, cascadeDelete: true)
                .Index(t => t.BookingID);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserType = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GuestID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        HotelID = c.Int(nullable: false),
                        TypeID = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .ForeignKey("dbo.RoomTypes", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.HotelID)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserType = c.String(nullable: false),
                        Name = c.String(),
                        Address = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Stars = c.String(nullable: false),
                        CheckinTime = c.DateTime(nullable: false),
                        CheckoutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HotelID);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PricePerNight = c.String(nullable: false),
                        Capacity = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TypeID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        HotelID = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Position = c.String(nullable: false),
                        Salary = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .Index(t => t.HotelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "HotelID", "dbo.Hotels");
            DropForeignKey("dbo.Bookings", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "TypeID", "dbo.RoomTypes");
            DropForeignKey("dbo.Rooms", "HotelID", "dbo.Hotels");
            DropForeignKey("dbo.Bookings", "GuestID", "dbo.Guests");
            DropForeignKey("dbo.Payments", "BookingID", "dbo.Bookings");
            DropIndex("dbo.Staffs", new[] { "HotelID" });
            DropIndex("dbo.Rooms", new[] { "TypeID" });
            DropIndex("dbo.Rooms", new[] { "HotelID" });
            DropIndex("dbo.Payments", new[] { "BookingID" });
            DropIndex("dbo.Bookings", new[] { "GuestID" });
            DropIndex("dbo.Bookings", new[] { "RoomID" });
            DropTable("dbo.Staffs");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Hotels");
            DropTable("dbo.Rooms");
            DropTable("dbo.Guests");
            DropTable("dbo.Payments");
            DropTable("dbo.Bookings");
        }
    }
}
