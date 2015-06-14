module TestProductSoldUsage

open System
open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Product Sold Usage`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] 
    member x.``Log Test At the beginning`` ()=         
            logger.Info("Test")

    [<SetUp>] 
    member x.``empty and prepare database`` ()=         
            logger.Info("Entered")
            let seed = new Oak.Seed()
            seed.PurgeDb()
            let schema = new CreateDB.Schema(seed)
            for s in schema.Scripts() do 
                let sql = s.Invoke()
                seed.ExecuteNonQuery( sql )
            logger.Info("Structure done ")

    [<Test>] 
    member x.``when I add product sold usage, it is added`` ()=
        let customerCategory = CustomerCategories.ensureCustomerCategory("customer category")
        let customer = Customers.ensureCustomer( "customer", customerCategory )

        let productCategory = ProductCategories.ensureProductCategory( "product category" )
        let product = Products.ensureProduct( "product", "code" )
        let product = Products.ensureProduct( "strange product", "strangecode" )
        let productCategoryMembership = ProductCategoryMemberships.ensureProductCategoryMembership(product, productCategory)

        let productSold = ProductsSoldToCustomers.ensureProductSoldToCustomer( product, customer, DateTime.Now, decimal 3.14, decimal 2.78 )

        let productUsage = ProductUsages.ensureProductUsage( "product usage" )

        let mySuccessLevel = decimal 0.50
        let saleValued = ProductsSoldToCustomers.addCustomerValueToProductSold( productSold, productUsage, "Very useful!", mySuccessLevel )

        saleValued.UsageSuccessLevel.Value |> should equal mySuccessLevel
        0 |> ignore