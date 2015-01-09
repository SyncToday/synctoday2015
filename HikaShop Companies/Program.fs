// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    try
        for address in Repository.getAddresses do
            printfn "%A" address.address_id
            Repository.saveAddress(address)
        for user in Repository.getUsers do
            printfn "%A" user.user_id
            Repository.saveUser(user)
        for order in Repository.getOrders do
            printfn "%A" order.order_id
            Repository.saveOrder(order)
        for product in Repository.getProducts do
            printfn "%A" product.product_id
            Repository.saveProduct(product)
        for orderProduct in Repository.getOrderProducts do
            printfn "%A" orderProduct.order_product_id
            Repository.saveOrderProduct(orderProduct)
    with
        | ex -> raise (System.ArgumentException("hikashop sync failed", ex))

    0 // return an integer exit code
