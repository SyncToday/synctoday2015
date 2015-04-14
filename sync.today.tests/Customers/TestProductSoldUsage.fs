module TestProductSoldUsage

open NUnit.Framework

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

        let product = Products.ensureProduct( "product" )
        let productUsage = ProductUsages.ensureProduct( "product usage" )

        0 |> ignore