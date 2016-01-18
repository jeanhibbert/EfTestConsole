namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "Person.Address",
            //    c => new
            //        {
            //            AddressID = c.Int(nullable: false, identity: true),
            //            AddressLine1 = c.String(nullable: false, maxLength: 60),
            //            AddressLine2 = c.String(maxLength: 60),
            //            City = c.String(nullable: false, maxLength: 30),
            //            StateProvinceID = c.Int(nullable: false),
            //            PostalCode = c.String(nullable: false, maxLength: 15),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.AddressID)
            //    .ForeignKey("Person.StateProvince", t => t.StateProvinceID, cascadeDelete: true)
            //    .Index(t => t.StateProvinceID);
            
            //CreateTable(
            //    "Sales.CustomerAddress",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            AddressID = c.Int(nullable: false),
            //            AddressTypeID = c.Int(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.CustomerID, t.AddressID })
            //    .ForeignKey("Person.Address", t => t.AddressID, cascadeDelete: true)
            //    .ForeignKey("Person.AddressType", t => t.AddressTypeID, cascadeDelete: true)
            //    .ForeignKey("Sales.Customer", t => t.CustomerID, cascadeDelete: true)
            //    .Index(t => t.CustomerID)
            //    .Index(t => t.AddressID)
            //    .Index(t => t.AddressTypeID);
            
            //CreateTable(
            //    "Person.AddressType",
            //    c => new
            //        {
            //            AddressTypeID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.AddressTypeID);
            
            //CreateTable(
            //    "Purchasing.VendorAddress",
            //    c => new
            //        {
            //            VendorID = c.Int(nullable: false),
            //            AddressID = c.Int(nullable: false),
            //            AddressTypeID = c.Int(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.VendorID, t.AddressID })
            //    .ForeignKey("Person.Address", t => t.AddressID, cascadeDelete: true)
            //    .ForeignKey("Person.AddressType", t => t.AddressTypeID, cascadeDelete: true)
            //    .ForeignKey("Purchasing.Vendor", t => t.VendorID, cascadeDelete: true)
            //    .Index(t => t.VendorID)
            //    .Index(t => t.AddressID)
            //    .Index(t => t.AddressTypeID);
            
            //CreateTable(
            //    "Purchasing.Vendor",
            //    c => new
            //        {
            //            VendorID = c.Int(nullable: false, identity: true),
            //            AccountNumber = c.String(nullable: false, maxLength: 15),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            CreditRating = c.Byte(nullable: false),
            //            PreferredVendorStatus = c.Boolean(nullable: false),
            //            ActiveFlag = c.Boolean(nullable: false),
            //            PurchasingWebServiceURL = c.String(maxLength: 1024),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.VendorID);
            
            //CreateTable(
            //    "Purchasing.ProductVendor",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            VendorID = c.Int(nullable: false),
            //            AverageLeadTime = c.Int(nullable: false),
            //            StandardPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            LastReceiptCost = c.Decimal(precision: 18, scale: 2),
            //            LastReceiptDate = c.DateTime(),
            //            MinOrderQty = c.Int(nullable: false),
            //            MaxOrderQty = c.Int(nullable: false),
            //            OnOrderQty = c.Int(),
            //            UnitMeasureCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.VendorID })
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .ForeignKey("Production.UnitMeasure", t => t.UnitMeasureCode, cascadeDelete: true)
            //    .ForeignKey("Purchasing.Vendor", t => t.VendorID, cascadeDelete: true)
            //    .Index(t => t.ProductID)
            //    .Index(t => t.VendorID)
            //    .Index(t => t.UnitMeasureCode);
            
            //CreateTable(
            //    "Production.Product",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ProductNumber = c.String(nullable: false, maxLength: 25),
            //            MakeFlag = c.Boolean(nullable: false),
            //            FinishedGoodsFlag = c.Boolean(nullable: false),
            //            Color = c.String(maxLength: 15),
            //            SafetyStockLevel = c.Short(nullable: false),
            //            ReorderPoint = c.Short(nullable: false),
            //            StandardCost = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ListPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Size = c.String(maxLength: 5),
            //            SizeUnitMeasureCode = c.String(maxLength: 3, fixedLength: true),
            //            WeightUnitMeasureCode = c.String(maxLength: 3, fixedLength: true),
            //            Weight = c.Decimal(precision: 18, scale: 2),
            //            DaysToManufacture = c.Int(nullable: false),
            //            ProductLine = c.String(maxLength: 2, fixedLength: true),
            //            Class = c.String(maxLength: 2, fixedLength: true),
            //            Style = c.String(maxLength: 2, fixedLength: true),
            //            ProductSubcategoryID = c.Int(),
            //            ProductModelID = c.Int(),
            //            SellStartDate = c.DateTime(nullable: false),
            //            SellEndDate = c.DateTime(),
            //            DiscontinuedDate = c.DateTime(),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductID)
            //    .ForeignKey("Production.ProductModel", t => t.ProductModelID)
            //    .ForeignKey("Production.ProductSubcategory", t => t.ProductSubcategoryID)
            //    .ForeignKey("Production.UnitMeasure", t => t.SizeUnitMeasureCode)
            //    .ForeignKey("Production.UnitMeasure", t => t.WeightUnitMeasureCode)
            //    .Index(t => t.SizeUnitMeasureCode)
            //    .Index(t => t.WeightUnitMeasureCode)
            //    .Index(t => t.ProductSubcategoryID)
            //    .Index(t => t.ProductModelID);
            
            //CreateTable(
            //    "Production.BillOfMaterials",
            //    c => new
            //        {
            //            BillOfMaterialsID = c.Int(nullable: false, identity: true),
            //            ProductAssemblyID = c.Int(),
            //            ComponentID = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(),
            //            UnitMeasureCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            BOMLevel = c.Short(nullable: false),
            //            PerAssemblyQty = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.BillOfMaterialsID)
            //    .ForeignKey("Production.Product", t => t.ComponentID, cascadeDelete: true)
            //    .ForeignKey("Production.Product", t => t.ProductAssemblyID)
            //    .ForeignKey("Production.UnitMeasure", t => t.UnitMeasureCode, cascadeDelete: true)
            //    .Index(t => t.ProductAssemblyID)
            //    .Index(t => t.ComponentID)
            //    .Index(t => t.UnitMeasureCode);
            
            //CreateTable(
            //    "Production.UnitMeasure",
            //    c => new
            //        {
            //            UnitMeasureCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.UnitMeasureCode);
            
            //CreateTable(
            //    "Production.ProductCostHistory",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(),
            //            StandardCost = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.StartDate })
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "Production.ProductDocument",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            DocumentID = c.Int(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.DocumentID })
            //    .ForeignKey("Production.Document", t => t.DocumentID, cascadeDelete: true)
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID)
            //    .Index(t => t.DocumentID);
            
            //CreateTable(
            //    "Production.Document",
            //    c => new
            //        {
            //            DocumentID = c.Int(nullable: false, identity: true),
            //            Title = c.String(nullable: false, maxLength: 50),
            //            FileName = c.String(nullable: false, maxLength: 400),
            //            FileExtension = c.String(nullable: false, maxLength: 8),
            //            Revision = c.String(nullable: false, maxLength: 5, fixedLength: true),
            //            ChangeNumber = c.Int(nullable: false),
            //            Status = c.Byte(nullable: false),
            //            DocumentSummary = c.String(),
            //            Document = c.Binary(),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.DocumentID);
            
            //CreateTable(
            //    "Production.ProductInventory",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            LocationID = c.Short(nullable: false),
            //            Shelf = c.String(nullable: false, maxLength: 10),
            //            Bin = c.Byte(nullable: false),
            //            Quantity = c.Short(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.LocationID })
            //    .ForeignKey("Production.Location", t => t.LocationID, cascadeDelete: true)
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "Production.Location",
            //    c => new
            //        {
            //            LocationID = c.Short(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            CostRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Availability = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.LocationID);
            
            //CreateTable(
            //    "Production.WorkOrderRouting",
            //    c => new
            //        {
            //            WorkOrderID = c.Int(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            OperationSequence = c.Short(nullable: false),
            //            LocationID = c.Short(nullable: false),
            //            ScheduledStartDate = c.DateTime(nullable: false),
            //            ScheduledEndDate = c.DateTime(nullable: false),
            //            ActualStartDate = c.DateTime(),
            //            ActualEndDate = c.DateTime(),
            //            ActualResourceHrs = c.Decimal(precision: 18, scale: 2),
            //            PlannedCost = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ActualCost = c.Decimal(precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.WorkOrderID, t.ProductID, t.OperationSequence })
            //    .ForeignKey("Production.Location", t => t.LocationID, cascadeDelete: true)
            //    .ForeignKey("Production.WorkOrder", t => t.WorkOrderID, cascadeDelete: true)
            //    .Index(t => t.WorkOrderID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "Production.WorkOrder",
            //    c => new
            //        {
            //            WorkOrderID = c.Int(nullable: false, identity: true),
            //            ProductID = c.Int(nullable: false),
            //            OrderQty = c.Int(nullable: false),
            //            StockedQty = c.Int(nullable: false),
            //            ScrappedQty = c.Short(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(),
            //            DueDate = c.DateTime(nullable: false),
            //            ScrapReasonID = c.Short(),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.WorkOrderID)
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .ForeignKey("Production.ScrapReason", t => t.ScrapReasonID)
            //    .Index(t => t.ProductID)
            //    .Index(t => t.ScrapReasonID);
            
            //CreateTable(
            //    "Production.ScrapReason",
            //    c => new
            //        {
            //            ScrapReasonID = c.Short(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ScrapReasonID);
            
            //CreateTable(
            //    "Production.ProductListPriceHistory",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(),
            //            ListPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.StartDate })
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "Production.ProductModel",
            //    c => new
            //        {
            //            ProductModelID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            CatalogDescription = c.String(),
            //            Instructions = c.String(),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductModelID);
            
            //CreateTable(
            //    "Production.ProductModelIllustration",
            //    c => new
            //        {
            //            ProductModelID = c.Int(nullable: false),
            //            IllustrationID = c.Int(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductModelID, t.IllustrationID })
            //    .ForeignKey("Production.Illustration", t => t.IllustrationID, cascadeDelete: true)
            //    .ForeignKey("Production.ProductModel", t => t.ProductModelID, cascadeDelete: true)
            //    .Index(t => t.ProductModelID)
            //    .Index(t => t.IllustrationID);
            
            //CreateTable(
            //    "Production.Illustration",
            //    c => new
            //        {
            //            IllustrationID = c.Int(nullable: false, identity: true),
            //            Diagram = c.String(),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.IllustrationID);
            
            //CreateTable(
            //    "Production.ProductModelProductDescriptionCulture",
            //    c => new
            //        {
            //            ProductModelID = c.Int(nullable: false),
            //            ProductDescriptionID = c.Int(nullable: false),
            //            CultureID = c.String(nullable: false, maxLength: 6, fixedLength: true),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductModelID, t.ProductDescriptionID, t.CultureID })
            //    .ForeignKey("Production.Culture", t => t.CultureID, cascadeDelete: true)
            //    .ForeignKey("Production.ProductDescription", t => t.ProductDescriptionID, cascadeDelete: true)
            //    .ForeignKey("Production.ProductModel", t => t.ProductModelID, cascadeDelete: true)
            //    .Index(t => t.ProductModelID)
            //    .Index(t => t.ProductDescriptionID)
            //    .Index(t => t.CultureID);
            
            //CreateTable(
            //    "Production.Culture",
            //    c => new
            //        {
            //            CultureID = c.String(nullable: false, maxLength: 6, fixedLength: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CultureID);
            
            //CreateTable(
            //    "Production.ProductDescription",
            //    c => new
            //        {
            //            ProductDescriptionID = c.Int(nullable: false, identity: true),
            //            Description = c.String(nullable: false, maxLength: 400),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductDescriptionID);
            
            //CreateTable(
            //    "Production.ProductProductPhoto",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            ProductPhotoID = c.Int(nullable: false),
            //            Primary = c.Boolean(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.ProductPhotoID })
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .ForeignKey("Production.ProductPhoto", t => t.ProductPhotoID, cascadeDelete: true)
            //    .Index(t => t.ProductID)
            //    .Index(t => t.ProductPhotoID);
            
            //CreateTable(
            //    "Production.ProductPhoto",
            //    c => new
            //        {
            //            ProductPhotoID = c.Int(nullable: false, identity: true),
            //            ThumbNailPhoto = c.Binary(),
            //            ThumbnailPhotoFileName = c.String(maxLength: 50),
            //            LargePhoto = c.Binary(),
            //            LargePhotoFileName = c.String(maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductPhotoID);
            
            //CreateTable(
            //    "Production.ProductReview",
            //    c => new
            //        {
            //            ProductReviewID = c.Int(nullable: false, identity: true),
            //            ProductID = c.Int(nullable: false),
            //            ReviewerName = c.String(nullable: false, maxLength: 50),
            //            ReviewDate = c.DateTime(nullable: false),
            //            EmailAddress = c.String(nullable: false, maxLength: 50),
            //            Rating = c.Int(nullable: false),
            //            Comments = c.String(maxLength: 3850),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductReviewID)
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "Production.ProductSubcategory",
            //    c => new
            //        {
            //            ProductSubcategoryID = c.Int(nullable: false, identity: true),
            //            ProductCategoryID = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductSubcategoryID)
            //    .ForeignKey("Production.ProductCategory", t => t.ProductCategoryID, cascadeDelete: true)
            //    .Index(t => t.ProductCategoryID);
            
            //CreateTable(
            //    "Production.ProductCategory",
            //    c => new
            //        {
            //            ProductCategoryID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductCategoryID);
            
            //CreateTable(
            //    "Purchasing.PurchaseOrderDetail",
            //    c => new
            //        {
            //            PurchaseOrderID = c.Int(nullable: false),
            //            PurchaseOrderDetailID = c.Int(nullable: false, identity: true),
            //            DueDate = c.DateTime(nullable: false),
            //            OrderQty = c.Short(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ReceivedQty = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            RejectedQty = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            StockedQty = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.PurchaseOrderID, t.PurchaseOrderDetailID })
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .ForeignKey("Purchasing.PurchaseOrderHeader", t => t.PurchaseOrderID, cascadeDelete: true)
            //    .Index(t => t.PurchaseOrderID)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "Purchasing.PurchaseOrderHeader",
            //    c => new
            //        {
            //            PurchaseOrderID = c.Int(nullable: false, identity: true),
            //            RevisionNumber = c.Byte(nullable: false),
            //            Status = c.Byte(nullable: false),
            //            EmployeeID = c.Int(nullable: false),
            //            VendorID = c.Int(nullable: false),
            //            ShipMethodID = c.Int(nullable: false),
            //            OrderDate = c.DateTime(nullable: false),
            //            ShipDate = c.DateTime(),
            //            SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TaxAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Freight = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TotalDue = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PurchaseOrderID)
            //    .ForeignKey("HumanResources.Employee", t => t.EmployeeID, cascadeDelete: true)
            //    .ForeignKey("Purchasing.ShipMethod", t => t.ShipMethodID, cascadeDelete: true)
            //    .ForeignKey("Purchasing.Vendor", t => t.VendorID, cascadeDelete: true)
            //    .Index(t => t.EmployeeID)
            //    .Index(t => t.VendorID)
            //    .Index(t => t.ShipMethodID);
            
            //CreateTable(
            //    "HumanResources.Employee",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false, identity: true),
            //            NationalIDNumber = c.String(nullable: false, maxLength: 15),
            //            ContactID = c.Int(nullable: false),
            //            LoginID = c.String(nullable: false, maxLength: 256),
            //            ManagerID = c.Int(),
            //            Title = c.String(nullable: false, maxLength: 50),
            //            BirthDate = c.DateTime(nullable: false),
            //            MaritalStatus = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            Gender = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            HireDate = c.DateTime(nullable: false),
            //            SalariedFlag = c.Boolean(nullable: false),
            //            VacationHours = c.Short(nullable: false),
            //            SickLeaveHours = c.Short(nullable: false),
            //            CurrentFlag = c.Boolean(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.EmployeeID)
            //    .ForeignKey("Person.Contact", t => t.ContactID, cascadeDelete: true)
            //    .ForeignKey("HumanResources.Employee", t => t.ManagerID)
            //    .Index(t => t.ContactID)
            //    .Index(t => t.ManagerID);
            
            //CreateTable(
            //    "Person.Contact",
            //    c => new
            //        {
            //            ContactID = c.Int(nullable: false, identity: true),
            //            NameStyle = c.Boolean(nullable: false),
            //            Title = c.String(maxLength: 8),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            MiddleName = c.String(maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            EmailAddress = c.String(maxLength: 50),
            //            EmailPromotion = c.Int(nullable: false),
            //            Phone = c.String(maxLength: 25),
            //            PasswordHash = c.String(nullable: false, maxLength: 128),
            //            PasswordSalt = c.String(nullable: false, maxLength: 10),
            //            AdditionalContactInfo = c.String(),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ContactID);
            
            //CreateTable(
            //    "Sales.ContactCreditCard",
            //    c => new
            //        {
            //            ContactID = c.Int(nullable: false),
            //            CreditCardID = c.Int(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ContactID, t.CreditCardID })
            //    .ForeignKey("Person.Contact", t => t.ContactID, cascadeDelete: true)
            //    .ForeignKey("Sales.CreditCard", t => t.CreditCardID, cascadeDelete: true)
            //    .Index(t => t.ContactID)
            //    .Index(t => t.CreditCardID);
            
            //CreateTable(
            //    "Sales.CreditCard",
            //    c => new
            //        {
            //            CreditCardID = c.Int(nullable: false, identity: true),
            //            CardType = c.String(nullable: false, maxLength: 50),
            //            CardNumber = c.String(nullable: false, maxLength: 25),
            //            ExpMonth = c.Byte(nullable: false),
            //            ExpYear = c.Short(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CreditCardID);
            
            //CreateTable(
            //    "Sales.SalesOrderHeader",
            //    c => new
            //        {
            //            SalesOrderID = c.Int(nullable: false, identity: true),
            //            RevisionNumber = c.Byte(nullable: false),
            //            OrderDate = c.DateTime(nullable: false),
            //            DueDate = c.DateTime(nullable: false),
            //            ShipDate = c.DateTime(),
            //            Status = c.Byte(nullable: false),
            //            OnlineOrderFlag = c.Boolean(nullable: false),
            //            SalesOrderNumber = c.String(nullable: false, maxLength: 25),
            //            PurchaseOrderNumber = c.String(maxLength: 25),
            //            AccountNumber = c.String(maxLength: 15),
            //            CustomerID = c.Int(nullable: false),
            //            ContactID = c.Int(nullable: false),
            //            SalesPersonID = c.Int(),
            //            TerritoryID = c.Int(),
            //            BillToAddressID = c.Int(nullable: false),
            //            ShipToAddressID = c.Int(nullable: false),
            //            ShipMethodID = c.Int(nullable: false),
            //            CreditCardID = c.Int(),
            //            CreditCardApprovalCode = c.String(maxLength: 15),
            //            CurrencyRateID = c.Int(),
            //            SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TaxAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Freight = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TotalDue = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Comment = c.String(maxLength: 128),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SalesOrderID)
            //    .ForeignKey("Person.Address", t => t.BillToAddressID, cascadeDelete: true)
            //    .ForeignKey("Person.Address", t => t.ShipToAddressID, cascadeDelete: true)
            //    .ForeignKey("Person.Contact", t => t.ContactID, cascadeDelete: true)
            //    .ForeignKey("Sales.CreditCard", t => t.CreditCardID)
            //    .ForeignKey("Sales.CurrencyRate", t => t.CurrencyRateID)
            //    .ForeignKey("Sales.Customer", t => t.CustomerID, cascadeDelete: true)
            //    .ForeignKey("Sales.SalesPerson", t => t.SalesPersonID)
            //    .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
            //    .ForeignKey("Purchasing.ShipMethod", t => t.ShipMethodID, cascadeDelete: true)
            //    .Index(t => t.CustomerID)
            //    .Index(t => t.ContactID)
            //    .Index(t => t.SalesPersonID)
            //    .Index(t => t.TerritoryID)
            //    .Index(t => t.BillToAddressID)
            //    .Index(t => t.ShipToAddressID)
            //    .Index(t => t.ShipMethodID)
            //    .Index(t => t.CreditCardID)
            //    .Index(t => t.CurrencyRateID);
            
            //CreateTable(
            //    "Sales.CurrencyRate",
            //    c => new
            //        {
            //            CurrencyRateID = c.Int(nullable: false, identity: true),
            //            CurrencyRateDate = c.DateTime(nullable: false),
            //            FromCurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            ToCurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            AverageRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            EndOfDayRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CurrencyRateID)
            //    .ForeignKey("Sales.Currency", t => t.FromCurrencyCode, cascadeDelete: true)
            //    .ForeignKey("Sales.Currency", t => t.ToCurrencyCode, cascadeDelete: true)
            //    .Index(t => t.FromCurrencyCode)
            //    .Index(t => t.ToCurrencyCode);
            
            //CreateTable(
            //    "Sales.Currency",
            //    c => new
            //        {
            //            CurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CurrencyCode);
            
            //CreateTable(
            //    "Sales.CountryRegionCurrency",
            //    c => new
            //        {
            //            CountryRegionCode = c.String(nullable: false, maxLength: 3),
            //            CurrencyCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.CountryRegionCode, t.CurrencyCode })
            //    .ForeignKey("Person.CountryRegion", t => t.CountryRegionCode, cascadeDelete: true)
            //    .ForeignKey("Sales.Currency", t => t.CurrencyCode, cascadeDelete: true)
            //    .Index(t => t.CountryRegionCode)
            //    .Index(t => t.CurrencyCode);
            
            //CreateTable(
            //    "Person.CountryRegion",
            //    c => new
            //        {
            //            CountryRegionCode = c.String(nullable: false, maxLength: 3),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CountryRegionCode);
            
            //CreateTable(
            //    "Person.StateProvince",
            //    c => new
            //        {
            //            StateProvinceID = c.Int(nullable: false, identity: true),
            //            StateProvinceCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            CountryRegionCode = c.String(nullable: false, maxLength: 3),
            //            IsOnlyStateProvinceFlag = c.Boolean(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            TerritoryID = c.Int(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.StateProvinceID)
            //    .ForeignKey("Person.CountryRegion", t => t.CountryRegionCode, cascadeDelete: true)
            //    .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID, cascadeDelete: true)
            //    .Index(t => t.CountryRegionCode)
            //    .Index(t => t.TerritoryID);
            
            //CreateTable(
            //    "Sales.SalesTaxRate",
            //    c => new
            //        {
            //            SalesTaxRateID = c.Int(nullable: false, identity: true),
            //            StateProvinceID = c.Int(nullable: false),
            //            TaxType = c.Byte(nullable: false),
            //            TaxRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SalesTaxRateID)
            //    .ForeignKey("Person.StateProvince", t => t.StateProvinceID, cascadeDelete: true)
            //    .Index(t => t.StateProvinceID);
            
            //CreateTable(
            //    "Sales.SalesTerritory",
            //    c => new
            //        {
            //            TerritoryID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            CountryRegionCode = c.String(nullable: false, maxLength: 3),
            //            Group = c.String(nullable: false, maxLength: 50),
            //            SalesYTD = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SalesLastYear = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CostYTD = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CostLastYear = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TerritoryID);
            
            //CreateTable(
            //    "Sales.Customer",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false, identity: true),
            //            TerritoryID = c.Int(),
            //            AccountNumber = c.String(nullable: false, maxLength: 10),
            //            CustomerType = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CustomerID)
            //    .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
            //    .Index(t => t.TerritoryID);
            
            //CreateTable(
            //    "Sales.Individual",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            ContactID = c.Int(nullable: false),
            //            Demographics = c.String(),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CustomerID)
            //    .ForeignKey("Person.Contact", t => t.ContactID, cascadeDelete: true)
            //    .ForeignKey("Sales.Customer", t => t.CustomerID)
            //    .Index(t => t.CustomerID)
            //    .Index(t => t.ContactID);
            
            //CreateTable(
            //    "Sales.Store",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            SalesPersonID = c.Int(),
            //            Demographics = c.String(),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CustomerID)
            //    .ForeignKey("Sales.Customer", t => t.CustomerID)
            //    .ForeignKey("Sales.SalesPerson", t => t.SalesPersonID)
            //    .Index(t => t.CustomerID)
            //    .Index(t => t.SalesPersonID);
            
            //CreateTable(
            //    "Sales.SalesPerson",
            //    c => new
            //        {
            //            SalesPersonID = c.Int(nullable: false),
            //            TerritoryID = c.Int(),
            //            SalesQuota = c.Decimal(precision: 18, scale: 2),
            //            Bonus = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CommissionPct = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SalesYTD = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SalesLastYear = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SalesPersonID)
            //    .ForeignKey("HumanResources.Employee", t => t.SalesPersonID)
            //    .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID)
            //    .Index(t => t.SalesPersonID)
            //    .Index(t => t.TerritoryID);
            
            //CreateTable(
            //    "Sales.SalesPersonQuotaHistory",
            //    c => new
            //        {
            //            SalesPersonID = c.Int(nullable: false),
            //            QuotaDate = c.DateTime(nullable: false),
            //            SalesQuota = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.SalesPersonID, t.QuotaDate })
            //    .ForeignKey("Sales.SalesPerson", t => t.SalesPersonID, cascadeDelete: true)
            //    .Index(t => t.SalesPersonID);
            
            //CreateTable(
            //    "Sales.SalesTerritoryHistory",
            //    c => new
            //        {
            //            SalesPersonID = c.Int(nullable: false),
            //            TerritoryID = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.SalesPersonID, t.TerritoryID, t.StartDate })
            //    .ForeignKey("Sales.SalesPerson", t => t.SalesPersonID, cascadeDelete: true)
            //    .ForeignKey("Sales.SalesTerritory", t => t.TerritoryID, cascadeDelete: true)
            //    .Index(t => t.SalesPersonID)
            //    .Index(t => t.TerritoryID);
            
            //CreateTable(
            //    "Sales.StoreContact",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            ContactID = c.Int(nullable: false),
            //            ContactTypeID = c.Int(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.CustomerID, t.ContactID })
            //    .ForeignKey("Person.Contact", t => t.ContactID, cascadeDelete: true)
            //    .ForeignKey("Person.ContactType", t => t.ContactTypeID, cascadeDelete: true)
            //    .ForeignKey("Sales.Store", t => t.CustomerID, cascadeDelete: true)
            //    .Index(t => t.CustomerID)
            //    .Index(t => t.ContactID)
            //    .Index(t => t.ContactTypeID);
            
            //CreateTable(
            //    "Person.ContactType",
            //    c => new
            //        {
            //            ContactTypeID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ContactTypeID);
            
            //CreateTable(
            //    "Purchasing.VendorContact",
            //    c => new
            //        {
            //            VendorID = c.Int(nullable: false),
            //            ContactID = c.Int(nullable: false),
            //            ContactTypeID = c.Int(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.VendorID, t.ContactID })
            //    .ForeignKey("Person.Contact", t => t.ContactID, cascadeDelete: true)
            //    .ForeignKey("Person.ContactType", t => t.ContactTypeID, cascadeDelete: true)
            //    .ForeignKey("Purchasing.Vendor", t => t.VendorID, cascadeDelete: true)
            //    .Index(t => t.VendorID)
            //    .Index(t => t.ContactID)
            //    .Index(t => t.ContactTypeID);
            
            //CreateTable(
            //    "Sales.SalesOrderDetail",
            //    c => new
            //        {
            //            SalesOrderID = c.Int(nullable: false),
            //            SalesOrderDetailID = c.Int(nullable: false, identity: true),
            //            CarrierTrackingNumber = c.String(maxLength: 25),
            //            OrderQty = c.Short(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            SpecialOfferID = c.Int(nullable: false),
            //            UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UnitPriceDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.SalesOrderID, t.SalesOrderDetailID })
            //    .ForeignKey("Sales.SalesOrderHeader", t => t.SalesOrderID, cascadeDelete: true)
            //    .ForeignKey("Sales.SpecialOfferProduct", t => new { t.SpecialOfferID, t.ProductID }, cascadeDelete: true)
            //    .Index(t => t.SalesOrderID)
            //    .Index(t => new { t.SpecialOfferID, t.ProductID });
            
            //CreateTable(
            //    "Sales.SpecialOfferProduct",
            //    c => new
            //        {
            //            SpecialOfferID = c.Int(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.SpecialOfferID, t.ProductID })
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .ForeignKey("Sales.SpecialOffer", t => t.SpecialOfferID, cascadeDelete: true)
            //    .Index(t => t.SpecialOfferID)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "Sales.SpecialOffer",
            //    c => new
            //        {
            //            SpecialOfferID = c.Int(nullable: false, identity: true),
            //            Description = c.String(nullable: false, maxLength: 255),
            //            DiscountPct = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Type = c.String(nullable: false, maxLength: 50),
            //            Category = c.String(nullable: false, maxLength: 50),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(nullable: false),
            //            MinQty = c.Int(nullable: false),
            //            MaxQty = c.Int(),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SpecialOfferID);
            
            //CreateTable(
            //    "Sales.SalesOrderHeaderSalesReason",
            //    c => new
            //        {
            //            SalesOrderID = c.Int(nullable: false),
            //            SalesReasonID = c.Int(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.SalesOrderID, t.SalesReasonID })
            //    .ForeignKey("Sales.SalesOrderHeader", t => t.SalesOrderID, cascadeDelete: true)
            //    .ForeignKey("Sales.SalesReason", t => t.SalesReasonID, cascadeDelete: true)
            //    .Index(t => t.SalesOrderID)
            //    .Index(t => t.SalesReasonID);
            
            //CreateTable(
            //    "Sales.SalesReason",
            //    c => new
            //        {
            //            SalesReasonID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ReasonType = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SalesReasonID);
            
            //CreateTable(
            //    "Purchasing.ShipMethod",
            //    c => new
            //        {
            //            ShipMethodID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ShipBase = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ShipRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ShipMethodID);
            
            //CreateTable(
            //    "HumanResources.EmployeeAddress",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            AddressID = c.Int(nullable: false),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.AddressID })
            //    .ForeignKey("Person.Address", t => t.AddressID, cascadeDelete: true)
            //    .ForeignKey("HumanResources.Employee", t => t.EmployeeID, cascadeDelete: true)
            //    .Index(t => t.EmployeeID)
            //    .Index(t => t.AddressID);
            
            //CreateTable(
            //    "HumanResources.EmployeeDepartmentHistory",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            DepartmentID = c.Short(nullable: false),
            //            ShiftID = c.Byte(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.DepartmentID, t.ShiftID, t.StartDate })
            //    .ForeignKey("HumanResources.Department", t => t.DepartmentID, cascadeDelete: true)
            //    .ForeignKey("HumanResources.Employee", t => t.EmployeeID, cascadeDelete: true)
            //    .ForeignKey("HumanResources.Shift", t => t.ShiftID, cascadeDelete: true)
            //    .Index(t => t.EmployeeID)
            //    .Index(t => t.DepartmentID)
            //    .Index(t => t.ShiftID);
            
            //CreateTable(
            //    "HumanResources.Department",
            //    c => new
            //        {
            //            DepartmentID = c.Short(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            GroupName = c.String(nullable: false, maxLength: 50),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.DepartmentID);
            
            //CreateTable(
            //    "HumanResources.Shift",
            //    c => new
            //        {
            //            ShiftID = c.Byte(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            StartTime = c.DateTime(nullable: false),
            //            EndTime = c.DateTime(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ShiftID);
            
            //CreateTable(
            //    "HumanResources.EmployeePayHistory",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            RateChangeDate = c.DateTime(nullable: false),
            //            Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            PayFrequency = c.Byte(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.RateChangeDate })
            //    .ForeignKey("HumanResources.Employee", t => t.EmployeeID, cascadeDelete: true)
            //    .Index(t => t.EmployeeID);
            
            //CreateTable(
            //    "HumanResources.JobCandidate",
            //    c => new
            //        {
            //            JobCandidateID = c.Int(nullable: false, identity: true),
            //            EmployeeID = c.Int(),
            //            Resume = c.String(),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.JobCandidateID)
            //    .ForeignKey("HumanResources.Employee", t => t.EmployeeID)
            //    .Index(t => t.EmployeeID);
            
            //CreateTable(
            //    "Sales.ShoppingCartItem",
            //    c => new
            //        {
            //            ShoppingCartItemID = c.Int(nullable: false, identity: true),
            //            ShoppingCartID = c.String(nullable: false, maxLength: 50),
            //            Quantity = c.Int(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            DateCreated = c.DateTime(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ShoppingCartItemID)
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "Production.TransactionHistory",
            //    c => new
            //        {
            //            TransactionID = c.Int(nullable: false, identity: true),
            //            ProductID = c.Int(nullable: false),
            //            ReferenceOrderID = c.Int(nullable: false),
            //            ReferenceOrderLineID = c.Int(nullable: false),
            //            TransactionDate = c.DateTime(nullable: false),
            //            TransactionType = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            Quantity = c.Int(nullable: false),
            //            ActualCost = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TransactionID)
            //    .ForeignKey("Production.Product", t => t.ProductID, cascadeDelete: true)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "dbo.AWBuildVersion",
            //    c => new
            //        {
            //            SystemInformationID = c.Byte(nullable: false),
            //            DatabaseVersion = c.String(name: "Database Version", nullable: false, maxLength: 25),
            //            VersionDate = c.DateTime(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SystemInformationID);
            
            //CreateTable(
            //    "dbo.DatabaseLog",
            //    c => new
            //        {
            //            DatabaseLogID = c.Int(nullable: false, identity: true),
            //            PostTime = c.DateTime(nullable: false),
            //            DatabaseUser = c.String(nullable: false, maxLength: 128),
            //            Event = c.String(nullable: false, maxLength: 128),
            //            Schema = c.String(maxLength: 128),
            //            Object = c.String(maxLength: 128),
            //            TSQL = c.String(nullable: false),
            //            XmlEvent = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.DatabaseLogID);
            
            //CreateTable(
            //    "dbo.ErrorLog",
            //    c => new
            //        {
            //            ErrorLogID = c.Int(nullable: false, identity: true),
            //            ErrorTime = c.DateTime(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 128),
            //            ErrorNumber = c.Int(nullable: false),
            //            ErrorSeverity = c.Int(),
            //            ErrorState = c.Int(),
            //            ErrorProcedure = c.String(maxLength: 126),
            //            ErrorLine = c.Int(),
            //            ErrorMessage = c.String(nullable: false, maxLength: 4000),
            //        })
            //    .PrimaryKey(t => t.ErrorLogID);
            
            //CreateTable(
            //    "Production.TransactionHistoryArchive",
            //    c => new
            //        {
            //            TransactionID = c.Int(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            ReferenceOrderID = c.Int(nullable: false),
            //            ReferenceOrderLineID = c.Int(nullable: false),
            //            TransactionDate = c.DateTime(nullable: false),
            //            TransactionType = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            Quantity = c.Int(nullable: false),
            //            ActualCost = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ModifiedDate = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TransactionID);
            
            //CreateTable(
            //    "Person.vAdditionalContactInfo",
            //    c => new
            //        {
            //            ContactID = c.Int(nullable: false, identity: true),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //            MiddleName = c.String(maxLength: 50),
            //            TelephoneNumber = c.String(maxLength: 50),
            //            TelephoneSpecialInstructions = c.String(),
            //            Street = c.String(maxLength: 50),
            //            City = c.String(maxLength: 50),
            //            StateProvince = c.String(maxLength: 50),
            //            PostalCode = c.String(maxLength: 50),
            //            CountryRegion = c.String(maxLength: 50),
            //            HomeAddressSpecialInstructions = c.String(),
            //            EMailAddress = c.String(maxLength: 128),
            //            EMailSpecialInstructions = c.String(),
            //            EMailTelephoneNumber = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => new { t.ContactID, t.FirstName, t.LastName, t.rowguid, t.ModifiedDate });
            
            //CreateTable(
            //    "HumanResources.vEmployeeDepartmentHistory",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            Shift = c.String(nullable: false, maxLength: 50),
            //            Department = c.String(nullable: false, maxLength: 50),
            //            GroupName = c.String(nullable: false, maxLength: 50),
            //            StartDate = c.DateTime(nullable: false),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            EndDate = c.DateTime(),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.FirstName, t.LastName, t.Shift, t.Department, t.GroupName, t.StartDate });
            
            //CreateTable(
            //    "HumanResources.vEmployeeDepartment",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            JobTitle = c.String(nullable: false, maxLength: 50),
            //            Department = c.String(nullable: false, maxLength: 50),
            //            GroupName = c.String(nullable: false, maxLength: 50),
            //            StartDate = c.DateTime(nullable: false),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.FirstName, t.LastName, t.JobTitle, t.Department, t.GroupName, t.StartDate });
            
            //CreateTable(
            //    "HumanResources.vEmployee",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            JobTitle = c.String(nullable: false, maxLength: 50),
            //            EmailPromotion = c.Int(nullable: false),
            //            AddressLine1 = c.String(nullable: false, maxLength: 60),
            //            City = c.String(nullable: false, maxLength: 30),
            //            StateProvinceName = c.String(nullable: false, maxLength: 50),
            //            PostalCode = c.String(nullable: false, maxLength: 15),
            //            CountryRegionName = c.String(nullable: false, maxLength: 50),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 25),
            //            EmailAddress = c.String(maxLength: 50),
            //            AddressLine2 = c.String(maxLength: 60),
            //            AdditionalContactInfo = c.String(),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.FirstName, t.LastName, t.JobTitle, t.EmailPromotion, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
            //CreateTable(
            //    "Sales.vIndividualCustomer",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            EmailPromotion = c.Int(nullable: false),
            //            AddressType = c.String(nullable: false, maxLength: 50),
            //            AddressLine1 = c.String(nullable: false, maxLength: 60),
            //            City = c.String(nullable: false, maxLength: 30),
            //            StateProvinceName = c.String(nullable: false, maxLength: 50),
            //            PostalCode = c.String(nullable: false, maxLength: 15),
            //            CountryRegionName = c.String(nullable: false, maxLength: 50),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 25),
            //            EmailAddress = c.String(maxLength: 50),
            //            AddressLine2 = c.String(maxLength: 60),
            //            Demographics = c.String(),
            //        })
            //    .PrimaryKey(t => new { t.CustomerID, t.FirstName, t.LastName, t.EmailPromotion, t.AddressType, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
            //CreateTable(
            //    "Sales.vIndividualDemographics",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            TotalPurchaseYTD = c.Decimal(precision: 18, scale: 2),
            //            DateFirstPurchase = c.DateTime(),
            //            BirthDate = c.DateTime(),
            //            MaritalStatus = c.String(maxLength: 1),
            //            YearlyIncome = c.String(maxLength: 30),
            //            Gender = c.String(maxLength: 1),
            //            TotalChildren = c.Int(),
            //            NumberChildrenAtHome = c.Int(),
            //            Education = c.String(maxLength: 30),
            //            Occupation = c.String(maxLength: 30),
            //            HomeOwnerFlag = c.Boolean(),
            //            NumberCarsOwned = c.Int(),
            //        })
            //    .PrimaryKey(t => t.CustomerID);
            
            //CreateTable(
            //    "HumanResources.vJobCandidateEducation",
            //    c => new
            //        {
            //            JobCandidateID = c.Int(nullable: false, identity: true),
            //            EduLevel = c.String(name: "Edu.Level"),
            //            EduStartDate = c.DateTime(name: "Edu.StartDate"),
            //            EduEndDate = c.DateTime(name: "Edu.EndDate"),
            //            EduDegree = c.String(name: "Edu.Degree", maxLength: 50),
            //            EduMajor = c.String(name: "Edu.Major", maxLength: 50),
            //            EduMinor = c.String(name: "Edu.Minor", maxLength: 50),
            //            EduGPA = c.String(name: "Edu.GPA", maxLength: 5),
            //            EduGPAScale = c.String(name: "Edu.GPAScale", maxLength: 5),
            //            EduSchool = c.String(name: "Edu.School", maxLength: 100),
            //            EduLocCountryRegion = c.String(name: "Edu.Loc.CountryRegion", maxLength: 100),
            //            EduLocState = c.String(name: "Edu.Loc.State", maxLength: 100),
            //            EduLocCity = c.String(name: "Edu.Loc.City", maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.JobCandidateID);
            
            //CreateTable(
            //    "HumanResources.vJobCandidateEmployment",
            //    c => new
            //        {
            //            JobCandidateID = c.Int(nullable: false, identity: true),
            //            EmpStartDate = c.DateTime(name: "Emp.StartDate"),
            //            EmpEndDate = c.DateTime(name: "Emp.EndDate"),
            //            EmpOrgName = c.String(name: "Emp.OrgName", maxLength: 100),
            //            EmpJobTitle = c.String(name: "Emp.JobTitle", maxLength: 100),
            //            EmpResponsibility = c.String(name: "Emp.Responsibility"),
            //            EmpFunctionCategory = c.String(name: "Emp.FunctionCategory"),
            //            EmpIndustryCategory = c.String(name: "Emp.IndustryCategory"),
            //            EmpLocCountryRegion = c.String(name: "Emp.Loc.CountryRegion"),
            //            EmpLocState = c.String(name: "Emp.Loc.State"),
            //            EmpLocCity = c.String(name: "Emp.Loc.City"),
            //        })
            //    .PrimaryKey(t => t.JobCandidateID);
            
            //CreateTable(
            //    "HumanResources.vJobCandidate",
            //    c => new
            //        {
            //            JobCandidateID = c.Int(nullable: false, identity: true),
            //            ModifiedDate = c.DateTime(nullable: false),
            //            EmployeeID = c.Int(),
            //            NamePrefix = c.String(name: "Name.Prefix", maxLength: 30),
            //            NameFirst = c.String(name: "Name.First", maxLength: 30),
            //            NameMiddle = c.String(name: "Name.Middle", maxLength: 30),
            //            NameLast = c.String(name: "Name.Last", maxLength: 30),
            //            NameSuffix = c.String(name: "Name.Suffix", maxLength: 30),
            //            Skills = c.String(),
            //            AddrType = c.String(name: "Addr.Type", maxLength: 30),
            //            AddrLocCountryRegion = c.String(name: "Addr.Loc.CountryRegion", maxLength: 100),
            //            AddrLocState = c.String(name: "Addr.Loc.State", maxLength: 100),
            //            AddrLocCity = c.String(name: "Addr.Loc.City", maxLength: 100),
            //            AddrPostalCode = c.String(name: "Addr.PostalCode", maxLength: 20),
            //            EMail = c.String(),
            //            WebSite = c.String(),
            //        })
            //    .PrimaryKey(t => new { t.JobCandidateID, t.ModifiedDate });
            
            //CreateTable(
            //    "Production.vProductAndDescription",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ProductModel = c.String(nullable: false, maxLength: 50),
            //            CultureID = c.String(nullable: false, maxLength: 6, fixedLength: true),
            //            Description = c.String(nullable: false, maxLength: 400),
            //        })
            //    .PrimaryKey(t => new { t.ProductID, t.Name, t.ProductModel, t.CultureID, t.Description });
            
            //CreateTable(
            //    "Production.vProductModelCatalogDescription",
            //    c => new
            //        {
            //            ProductModelID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //            Summary = c.String(),
            //            Manufacturer = c.String(),
            //            Copyright = c.String(maxLength: 30),
            //            ProductURL = c.String(maxLength: 256),
            //            WarrantyPeriod = c.String(maxLength: 256),
            //            WarrantyDescription = c.String(maxLength: 256),
            //            NoOfYears = c.String(maxLength: 256),
            //            MaintenanceDescription = c.String(maxLength: 256),
            //            Wheel = c.String(maxLength: 256),
            //            Saddle = c.String(maxLength: 256),
            //            Pedal = c.String(maxLength: 256),
            //            BikeFrame = c.String(),
            //            Crankset = c.String(maxLength: 256),
            //            PictureAngle = c.String(maxLength: 256),
            //            PictureSize = c.String(maxLength: 256),
            //            ProductPhotoID = c.String(maxLength: 256),
            //            Material = c.String(maxLength: 256),
            //            Color = c.String(maxLength: 256),
            //            ProductLine = c.String(maxLength: 256),
            //            Style = c.String(maxLength: 256),
            //            RiderExperience = c.String(maxLength: 1024),
            //        })
            //    .PrimaryKey(t => new { t.ProductModelID, t.Name, t.rowguid, t.ModifiedDate });
            
            //CreateTable(
            //    "Production.vProductModelInstructions",
            //    c => new
            //        {
            //            ProductModelID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            rowguid = c.Guid(nullable: false),
            //            ModifiedDate = c.DateTime(nullable: false),
            //            Instructions = c.String(),
            //            LocationID = c.Int(),
            //            SetupHours = c.Decimal(precision: 18, scale: 2),
            //            MachineHours = c.Decimal(precision: 18, scale: 2),
            //            LaborHours = c.Decimal(precision: 18, scale: 2),
            //            LotSize = c.Int(),
            //            Step = c.String(maxLength: 1024),
            //        })
            //    .PrimaryKey(t => new { t.ProductModelID, t.Name, t.rowguid, t.ModifiedDate });
            
            //CreateTable(
            //    "Sales.vSalesPerson",
            //    c => new
            //        {
            //            SalesPersonID = c.Int(nullable: false),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            JobTitle = c.String(nullable: false, maxLength: 50),
            //            EmailPromotion = c.Int(nullable: false),
            //            AddressLine1 = c.String(nullable: false, maxLength: 60),
            //            City = c.String(nullable: false, maxLength: 30),
            //            StateProvinceName = c.String(nullable: false, maxLength: 50),
            //            PostalCode = c.String(nullable: false, maxLength: 15),
            //            CountryRegionName = c.String(nullable: false, maxLength: 50),
            //            SalesYTD = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SalesLastYear = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 25),
            //            EmailAddress = c.String(maxLength: 50),
            //            AddressLine2 = c.String(maxLength: 60),
            //            TerritoryName = c.String(maxLength: 50),
            //            TerritoryGroup = c.String(maxLength: 50),
            //            SalesQuota = c.Decimal(precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => new { t.SalesPersonID, t.FirstName, t.LastName, t.JobTitle, t.EmailPromotion, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName, t.SalesYTD, t.SalesLastYear });
            
            //CreateTable(
            //    "Sales.vSalesPersonSalesByFiscalYears",
            //    c => new
            //        {
            //            Title = c.String(nullable: false, maxLength: 50),
            //            SalesTerritory = c.String(nullable: false, maxLength: 50),
            //            SalesPersonID = c.Int(),
            //            FullName = c.String(maxLength: 152),
            //            _2002 = c.Decimal(name: "2002", precision: 18, scale: 2),
            //            _2003 = c.Decimal(name: "2003", precision: 18, scale: 2),
            //            _2004 = c.Decimal(name: "2004", precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => new { t.Title, t.SalesTerritory });
            
            //CreateTable(
            //    "Person.vStateProvinceCountryRegion",
            //    c => new
            //        {
            //            StateProvinceID = c.Int(nullable: false),
            //            StateProvinceCode = c.String(nullable: false, maxLength: 3, fixedLength: true),
            //            IsOnlyStateProvinceFlag = c.Boolean(nullable: false),
            //            StateProvinceName = c.String(nullable: false, maxLength: 50),
            //            TerritoryID = c.Int(nullable: false),
            //            CountryRegionCode = c.String(nullable: false, maxLength: 3),
            //            CountryRegionName = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => new { t.StateProvinceID, t.StateProvinceCode, t.IsOnlyStateProvinceFlag, t.StateProvinceName, t.TerritoryID, t.CountryRegionCode, t.CountryRegionName });
            
            //CreateTable(
            //    "Sales.vStoreWithDemographics",
            //    c => new
            //        {
            //            CustomerID = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ContactType = c.String(nullable: false, maxLength: 50),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            EmailPromotion = c.Int(nullable: false),
            //            AddressType = c.String(nullable: false, maxLength: 50),
            //            AddressLine1 = c.String(nullable: false, maxLength: 60),
            //            City = c.String(nullable: false, maxLength: 30),
            //            StateProvinceName = c.String(nullable: false, maxLength: 50),
            //            PostalCode = c.String(nullable: false, maxLength: 15),
            //            CountryRegionName = c.String(nullable: false, maxLength: 50),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 25),
            //            EmailAddress = c.String(maxLength: 50),
            //            AddressLine2 = c.String(maxLength: 60),
            //            AnnualSales = c.Decimal(precision: 18, scale: 2),
            //            AnnualRevenue = c.Decimal(precision: 18, scale: 2),
            //            BankName = c.String(maxLength: 50),
            //            BusinessType = c.String(maxLength: 5),
            //            YearOpened = c.Int(),
            //            Specialty = c.String(maxLength: 50),
            //            SquareFeet = c.Int(),
            //            Brands = c.String(maxLength: 30),
            //            Internet = c.String(maxLength: 30),
            //            NumberEmployees = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.CustomerID, t.Name, t.ContactType, t.FirstName, t.LastName, t.EmailPromotion, t.AddressType, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
            //CreateTable(
            //    "Purchasing.vVendor",
            //    c => new
            //        {
            //            VendorID = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            ContactType = c.String(nullable: false, maxLength: 50),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 50),
            //            EmailPromotion = c.Int(nullable: false),
            //            AddressLine1 = c.String(nullable: false, maxLength: 60),
            //            City = c.String(nullable: false, maxLength: 30),
            //            StateProvinceName = c.String(nullable: false, maxLength: 50),
            //            PostalCode = c.String(nullable: false, maxLength: 15),
            //            CountryRegionName = c.String(nullable: false, maxLength: 50),
            //            Title = c.String(maxLength: 8),
            //            MiddleName = c.String(maxLength: 50),
            //            Suffix = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 25),
            //            EmailAddress = c.String(maxLength: 50),
            //            AddressLine2 = c.String(maxLength: 60),
            //        })
            //    .PrimaryKey(t => new { t.VendorID, t.Name, t.ContactType, t.FirstName, t.LastName, t.EmailPromotion, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });
            
        }
        
        public override void Down()
        {
            DropForeignKey("Person.Address", "StateProvinceID", "Person.StateProvince");
            DropForeignKey("Sales.CustomerAddress", "CustomerID", "Sales.Customer");
            DropForeignKey("Sales.CustomerAddress", "AddressTypeID", "Person.AddressType");
            DropForeignKey("Purchasing.VendorAddress", "VendorID", "Purchasing.Vendor");
            DropForeignKey("Purchasing.ProductVendor", "VendorID", "Purchasing.Vendor");
            DropForeignKey("Purchasing.ProductVendor", "UnitMeasureCode", "Production.UnitMeasure");
            DropForeignKey("Purchasing.ProductVendor", "ProductID", "Production.Product");
            DropForeignKey("Production.Product", "WeightUnitMeasureCode", "Production.UnitMeasure");
            DropForeignKey("Production.Product", "SizeUnitMeasureCode", "Production.UnitMeasure");
            DropForeignKey("Production.TransactionHistory", "ProductID", "Production.Product");
            DropForeignKey("Sales.ShoppingCartItem", "ProductID", "Production.Product");
            DropForeignKey("Purchasing.PurchaseOrderDetail", "PurchaseOrderID", "Purchasing.PurchaseOrderHeader");
            DropForeignKey("Purchasing.PurchaseOrderHeader", "VendorID", "Purchasing.Vendor");
            DropForeignKey("Purchasing.PurchaseOrderHeader", "ShipMethodID", "Purchasing.ShipMethod");
            DropForeignKey("Purchasing.PurchaseOrderHeader", "EmployeeID", "HumanResources.Employee");
            DropForeignKey("HumanResources.JobCandidate", "EmployeeID", "HumanResources.Employee");
            DropForeignKey("HumanResources.EmployeePayHistory", "EmployeeID", "HumanResources.Employee");
            DropForeignKey("HumanResources.EmployeeDepartmentHistory", "ShiftID", "HumanResources.Shift");
            DropForeignKey("HumanResources.EmployeeDepartmentHistory", "EmployeeID", "HumanResources.Employee");
            DropForeignKey("HumanResources.EmployeeDepartmentHistory", "DepartmentID", "HumanResources.Department");
            DropForeignKey("HumanResources.EmployeeAddress", "EmployeeID", "HumanResources.Employee");
            DropForeignKey("HumanResources.EmployeeAddress", "AddressID", "Person.Address");
            DropForeignKey("HumanResources.Employee", "ManagerID", "HumanResources.Employee");
            DropForeignKey("HumanResources.Employee", "ContactID", "Person.Contact");
            DropForeignKey("Sales.ContactCreditCard", "CreditCardID", "Sales.CreditCard");
            DropForeignKey("Sales.SalesOrderHeader", "ShipMethodID", "Purchasing.ShipMethod");
            DropForeignKey("Sales.SalesOrderHeader", "TerritoryID", "Sales.SalesTerritory");
            DropForeignKey("Sales.SalesOrderHeader", "SalesPersonID", "Sales.SalesPerson");
            DropForeignKey("Sales.SalesOrderHeaderSalesReason", "SalesReasonID", "Sales.SalesReason");
            DropForeignKey("Sales.SalesOrderHeaderSalesReason", "SalesOrderID", "Sales.SalesOrderHeader");
            DropForeignKey("Sales.SalesOrderDetail", new[] { "SpecialOfferID", "ProductID" }, "Sales.SpecialOfferProduct");
            DropForeignKey("Sales.SpecialOfferProduct", "SpecialOfferID", "Sales.SpecialOffer");
            DropForeignKey("Sales.SpecialOfferProduct", "ProductID", "Production.Product");
            DropForeignKey("Sales.SalesOrderDetail", "SalesOrderID", "Sales.SalesOrderHeader");
            DropForeignKey("Sales.SalesOrderHeader", "CustomerID", "Sales.Customer");
            DropForeignKey("Sales.SalesOrderHeader", "CurrencyRateID", "Sales.CurrencyRate");
            DropForeignKey("Sales.CurrencyRate", "ToCurrencyCode", "Sales.Currency");
            DropForeignKey("Sales.CurrencyRate", "FromCurrencyCode", "Sales.Currency");
            DropForeignKey("Sales.CountryRegionCurrency", "CurrencyCode", "Sales.Currency");
            DropForeignKey("Sales.CountryRegionCurrency", "CountryRegionCode", "Person.CountryRegion");
            DropForeignKey("Person.StateProvince", "TerritoryID", "Sales.SalesTerritory");
            DropForeignKey("Sales.StoreContact", "CustomerID", "Sales.Store");
            DropForeignKey("Sales.StoreContact", "ContactTypeID", "Person.ContactType");
            DropForeignKey("Purchasing.VendorContact", "VendorID", "Purchasing.Vendor");
            DropForeignKey("Purchasing.VendorContact", "ContactTypeID", "Person.ContactType");
            DropForeignKey("Purchasing.VendorContact", "ContactID", "Person.Contact");
            DropForeignKey("Sales.StoreContact", "ContactID", "Person.Contact");
            DropForeignKey("Sales.Store", "SalesPersonID", "Sales.SalesPerson");
            DropForeignKey("Sales.SalesTerritoryHistory", "TerritoryID", "Sales.SalesTerritory");
            DropForeignKey("Sales.SalesTerritoryHistory", "SalesPersonID", "Sales.SalesPerson");
            DropForeignKey("Sales.SalesPerson", "TerritoryID", "Sales.SalesTerritory");
            DropForeignKey("Sales.SalesPersonQuotaHistory", "SalesPersonID", "Sales.SalesPerson");
            DropForeignKey("Sales.SalesPerson", "SalesPersonID", "HumanResources.Employee");
            DropForeignKey("Sales.Store", "CustomerID", "Sales.Customer");
            DropForeignKey("Sales.Customer", "TerritoryID", "Sales.SalesTerritory");
            DropForeignKey("Sales.Individual", "CustomerID", "Sales.Customer");
            DropForeignKey("Sales.Individual", "ContactID", "Person.Contact");
            DropForeignKey("Sales.SalesTaxRate", "StateProvinceID", "Person.StateProvince");
            DropForeignKey("Person.StateProvince", "CountryRegionCode", "Person.CountryRegion");
            DropForeignKey("Sales.SalesOrderHeader", "CreditCardID", "Sales.CreditCard");
            DropForeignKey("Sales.SalesOrderHeader", "ContactID", "Person.Contact");
            DropForeignKey("Sales.SalesOrderHeader", "ShipToAddressID", "Person.Address");
            DropForeignKey("Sales.SalesOrderHeader", "BillToAddressID", "Person.Address");
            DropForeignKey("Sales.ContactCreditCard", "ContactID", "Person.Contact");
            DropForeignKey("Purchasing.PurchaseOrderDetail", "ProductID", "Production.Product");
            DropForeignKey("Production.Product", "ProductSubcategoryID", "Production.ProductSubcategory");
            DropForeignKey("Production.ProductSubcategory", "ProductCategoryID", "Production.ProductCategory");
            DropForeignKey("Production.ProductReview", "ProductID", "Production.Product");
            DropForeignKey("Production.ProductProductPhoto", "ProductPhotoID", "Production.ProductPhoto");
            DropForeignKey("Production.ProductProductPhoto", "ProductID", "Production.Product");
            DropForeignKey("Production.Product", "ProductModelID", "Production.ProductModel");
            DropForeignKey("Production.ProductModelProductDescriptionCulture", "ProductModelID", "Production.ProductModel");
            DropForeignKey("Production.ProductModelProductDescriptionCulture", "ProductDescriptionID", "Production.ProductDescription");
            DropForeignKey("Production.ProductModelProductDescriptionCulture", "CultureID", "Production.Culture");
            DropForeignKey("Production.ProductModelIllustration", "ProductModelID", "Production.ProductModel");
            DropForeignKey("Production.ProductModelIllustration", "IllustrationID", "Production.Illustration");
            DropForeignKey("Production.ProductListPriceHistory", "ProductID", "Production.Product");
            DropForeignKey("Production.ProductInventory", "ProductID", "Production.Product");
            DropForeignKey("Production.ProductInventory", "LocationID", "Production.Location");
            DropForeignKey("Production.WorkOrderRouting", "WorkOrderID", "Production.WorkOrder");
            DropForeignKey("Production.WorkOrder", "ScrapReasonID", "Production.ScrapReason");
            DropForeignKey("Production.WorkOrder", "ProductID", "Production.Product");
            DropForeignKey("Production.WorkOrderRouting", "LocationID", "Production.Location");
            DropForeignKey("Production.ProductDocument", "ProductID", "Production.Product");
            DropForeignKey("Production.ProductDocument", "DocumentID", "Production.Document");
            DropForeignKey("Production.ProductCostHistory", "ProductID", "Production.Product");
            DropForeignKey("Production.BillOfMaterials", "UnitMeasureCode", "Production.UnitMeasure");
            DropForeignKey("Production.BillOfMaterials", "ProductAssemblyID", "Production.Product");
            DropForeignKey("Production.BillOfMaterials", "ComponentID", "Production.Product");
            DropForeignKey("Purchasing.VendorAddress", "AddressTypeID", "Person.AddressType");
            DropForeignKey("Purchasing.VendorAddress", "AddressID", "Person.Address");
            DropForeignKey("Sales.CustomerAddress", "AddressID", "Person.Address");
            DropIndex("Production.TransactionHistory", new[] { "ProductID" });
            DropIndex("Sales.ShoppingCartItem", new[] { "ProductID" });
            DropIndex("HumanResources.JobCandidate", new[] { "EmployeeID" });
            DropIndex("HumanResources.EmployeePayHistory", new[] { "EmployeeID" });
            DropIndex("HumanResources.EmployeeDepartmentHistory", new[] { "ShiftID" });
            DropIndex("HumanResources.EmployeeDepartmentHistory", new[] { "DepartmentID" });
            DropIndex("HumanResources.EmployeeDepartmentHistory", new[] { "EmployeeID" });
            DropIndex("HumanResources.EmployeeAddress", new[] { "AddressID" });
            DropIndex("HumanResources.EmployeeAddress", new[] { "EmployeeID" });
            DropIndex("Sales.SalesOrderHeaderSalesReason", new[] { "SalesReasonID" });
            DropIndex("Sales.SalesOrderHeaderSalesReason", new[] { "SalesOrderID" });
            DropIndex("Sales.SpecialOfferProduct", new[] { "ProductID" });
            DropIndex("Sales.SpecialOfferProduct", new[] { "SpecialOfferID" });
            DropIndex("Sales.SalesOrderDetail", new[] { "SpecialOfferID", "ProductID" });
            DropIndex("Sales.SalesOrderDetail", new[] { "SalesOrderID" });
            DropIndex("Purchasing.VendorContact", new[] { "ContactTypeID" });
            DropIndex("Purchasing.VendorContact", new[] { "ContactID" });
            DropIndex("Purchasing.VendorContact", new[] { "VendorID" });
            DropIndex("Sales.StoreContact", new[] { "ContactTypeID" });
            DropIndex("Sales.StoreContact", new[] { "ContactID" });
            DropIndex("Sales.StoreContact", new[] { "CustomerID" });
            DropIndex("Sales.SalesTerritoryHistory", new[] { "TerritoryID" });
            DropIndex("Sales.SalesTerritoryHistory", new[] { "SalesPersonID" });
            DropIndex("Sales.SalesPersonQuotaHistory", new[] { "SalesPersonID" });
            DropIndex("Sales.SalesPerson", new[] { "TerritoryID" });
            DropIndex("Sales.SalesPerson", new[] { "SalesPersonID" });
            DropIndex("Sales.Store", new[] { "SalesPersonID" });
            DropIndex("Sales.Store", new[] { "CustomerID" });
            DropIndex("Sales.Individual", new[] { "ContactID" });
            DropIndex("Sales.Individual", new[] { "CustomerID" });
            DropIndex("Sales.Customer", new[] { "TerritoryID" });
            DropIndex("Sales.SalesTaxRate", new[] { "StateProvinceID" });
            DropIndex("Person.StateProvince", new[] { "TerritoryID" });
            DropIndex("Person.StateProvince", new[] { "CountryRegionCode" });
            DropIndex("Sales.CountryRegionCurrency", new[] { "CurrencyCode" });
            DropIndex("Sales.CountryRegionCurrency", new[] { "CountryRegionCode" });
            DropIndex("Sales.CurrencyRate", new[] { "ToCurrencyCode" });
            DropIndex("Sales.CurrencyRate", new[] { "FromCurrencyCode" });
            DropIndex("Sales.SalesOrderHeader", new[] { "CurrencyRateID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "CreditCardID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "ShipMethodID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "ShipToAddressID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "BillToAddressID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "TerritoryID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "SalesPersonID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "ContactID" });
            DropIndex("Sales.SalesOrderHeader", new[] { "CustomerID" });
            DropIndex("Sales.ContactCreditCard", new[] { "CreditCardID" });
            DropIndex("Sales.ContactCreditCard", new[] { "ContactID" });
            DropIndex("HumanResources.Employee", new[] { "ManagerID" });
            DropIndex("HumanResources.Employee", new[] { "ContactID" });
            DropIndex("Purchasing.PurchaseOrderHeader", new[] { "ShipMethodID" });
            DropIndex("Purchasing.PurchaseOrderHeader", new[] { "VendorID" });
            DropIndex("Purchasing.PurchaseOrderHeader", new[] { "EmployeeID" });
            DropIndex("Purchasing.PurchaseOrderDetail", new[] { "ProductID" });
            DropIndex("Purchasing.PurchaseOrderDetail", new[] { "PurchaseOrderID" });
            DropIndex("Production.ProductSubcategory", new[] { "ProductCategoryID" });
            DropIndex("Production.ProductReview", new[] { "ProductID" });
            DropIndex("Production.ProductProductPhoto", new[] { "ProductPhotoID" });
            DropIndex("Production.ProductProductPhoto", new[] { "ProductID" });
            DropIndex("Production.ProductModelProductDescriptionCulture", new[] { "CultureID" });
            DropIndex("Production.ProductModelProductDescriptionCulture", new[] { "ProductDescriptionID" });
            DropIndex("Production.ProductModelProductDescriptionCulture", new[] { "ProductModelID" });
            DropIndex("Production.ProductModelIllustration", new[] { "IllustrationID" });
            DropIndex("Production.ProductModelIllustration", new[] { "ProductModelID" });
            DropIndex("Production.ProductListPriceHistory", new[] { "ProductID" });
            DropIndex("Production.WorkOrder", new[] { "ScrapReasonID" });
            DropIndex("Production.WorkOrder", new[] { "ProductID" });
            DropIndex("Production.WorkOrderRouting", new[] { "LocationID" });
            DropIndex("Production.WorkOrderRouting", new[] { "WorkOrderID" });
            DropIndex("Production.ProductInventory", new[] { "LocationID" });
            DropIndex("Production.ProductInventory", new[] { "ProductID" });
            DropIndex("Production.ProductDocument", new[] { "DocumentID" });
            DropIndex("Production.ProductDocument", new[] { "ProductID" });
            DropIndex("Production.ProductCostHistory", new[] { "ProductID" });
            DropIndex("Production.BillOfMaterials", new[] { "UnitMeasureCode" });
            DropIndex("Production.BillOfMaterials", new[] { "ComponentID" });
            DropIndex("Production.BillOfMaterials", new[] { "ProductAssemblyID" });
            DropIndex("Production.Product", new[] { "ProductModelID" });
            DropIndex("Production.Product", new[] { "ProductSubcategoryID" });
            DropIndex("Production.Product", new[] { "WeightUnitMeasureCode" });
            DropIndex("Production.Product", new[] { "SizeUnitMeasureCode" });
            DropIndex("Purchasing.ProductVendor", new[] { "UnitMeasureCode" });
            DropIndex("Purchasing.ProductVendor", new[] { "VendorID" });
            DropIndex("Purchasing.ProductVendor", new[] { "ProductID" });
            DropIndex("Purchasing.VendorAddress", new[] { "AddressTypeID" });
            DropIndex("Purchasing.VendorAddress", new[] { "AddressID" });
            DropIndex("Purchasing.VendorAddress", new[] { "VendorID" });
            DropIndex("Sales.CustomerAddress", new[] { "AddressTypeID" });
            DropIndex("Sales.CustomerAddress", new[] { "AddressID" });
            DropIndex("Sales.CustomerAddress", new[] { "CustomerID" });
            DropIndex("Person.Address", new[] { "StateProvinceID" });
            DropTable("Purchasing.vVendor");
            DropTable("Sales.vStoreWithDemographics");
            DropTable("Person.vStateProvinceCountryRegion");
            DropTable("Sales.vSalesPersonSalesByFiscalYears");
            DropTable("Sales.vSalesPerson");
            DropTable("Production.vProductModelInstructions");
            DropTable("Production.vProductModelCatalogDescription");
            DropTable("Production.vProductAndDescription");
            DropTable("HumanResources.vJobCandidate");
            DropTable("HumanResources.vJobCandidateEmployment");
            DropTable("HumanResources.vJobCandidateEducation");
            DropTable("Sales.vIndividualDemographics");
            DropTable("Sales.vIndividualCustomer");
            DropTable("HumanResources.vEmployee");
            DropTable("HumanResources.vEmployeeDepartment");
            DropTable("HumanResources.vEmployeeDepartmentHistory");
            DropTable("Person.vAdditionalContactInfo");
            DropTable("Production.TransactionHistoryArchive");
            DropTable("dbo.ErrorLog");
            DropTable("dbo.DatabaseLog");
            DropTable("dbo.AWBuildVersion");
            DropTable("Production.TransactionHistory");
            DropTable("Sales.ShoppingCartItem");
            DropTable("HumanResources.JobCandidate");
            DropTable("HumanResources.EmployeePayHistory");
            DropTable("HumanResources.Shift");
            DropTable("HumanResources.Department");
            DropTable("HumanResources.EmployeeDepartmentHistory");
            DropTable("HumanResources.EmployeeAddress");
            DropTable("Purchasing.ShipMethod");
            DropTable("Sales.SalesReason");
            DropTable("Sales.SalesOrderHeaderSalesReason");
            DropTable("Sales.SpecialOffer");
            DropTable("Sales.SpecialOfferProduct");
            DropTable("Sales.SalesOrderDetail");
            DropTable("Purchasing.VendorContact");
            DropTable("Person.ContactType");
            DropTable("Sales.StoreContact");
            DropTable("Sales.SalesTerritoryHistory");
            DropTable("Sales.SalesPersonQuotaHistory");
            DropTable("Sales.SalesPerson");
            DropTable("Sales.Store");
            DropTable("Sales.Individual");
            DropTable("Sales.Customer");
            DropTable("Sales.SalesTerritory");
            DropTable("Sales.SalesTaxRate");
            DropTable("Person.StateProvince");
            DropTable("Person.CountryRegion");
            DropTable("Sales.CountryRegionCurrency");
            DropTable("Sales.Currency");
            DropTable("Sales.CurrencyRate");
            DropTable("Sales.SalesOrderHeader");
            DropTable("Sales.CreditCard");
            DropTable("Sales.ContactCreditCard");
            DropTable("Person.Contact");
            DropTable("HumanResources.Employee");
            DropTable("Purchasing.PurchaseOrderHeader");
            DropTable("Purchasing.PurchaseOrderDetail");
            DropTable("Production.ProductCategory");
            DropTable("Production.ProductSubcategory");
            DropTable("Production.ProductReview");
            DropTable("Production.ProductPhoto");
            DropTable("Production.ProductProductPhoto");
            DropTable("Production.ProductDescription");
            DropTable("Production.Culture");
            DropTable("Production.ProductModelProductDescriptionCulture");
            DropTable("Production.Illustration");
            DropTable("Production.ProductModelIllustration");
            DropTable("Production.ProductModel");
            DropTable("Production.ProductListPriceHistory");
            DropTable("Production.ScrapReason");
            DropTable("Production.WorkOrder");
            DropTable("Production.WorkOrderRouting");
            DropTable("Production.Location");
            DropTable("Production.ProductInventory");
            DropTable("Production.Document");
            DropTable("Production.ProductDocument");
            DropTable("Production.ProductCostHistory");
            DropTable("Production.UnitMeasure");
            DropTable("Production.BillOfMaterials");
            DropTable("Production.Product");
            DropTable("Purchasing.ProductVendor");
            DropTable("Purchasing.Vendor");
            DropTable("Purchasing.VendorAddress");
            DropTable("Person.AddressType");
            DropTable("Sales.CustomerAddress");
            DropTable("Person.Address");
        }
    }
}
