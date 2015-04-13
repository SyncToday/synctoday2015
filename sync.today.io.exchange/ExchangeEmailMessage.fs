namespace sync.today.Models

open System

[<CLIMutable>]
type ExchangeEmailMessageDTO =
    {   Id : int
        InternalId : Guid
        ExternalId : string
        LastModifiedTime : DateTime

        Subject : string
        Body : string

        BccRecipientsJSON : string
        CcRecipientsJSON : string
        //ConversationIndex : byte
        //ConversationTopic : string
        From : string
        InternetMessageId : string
        //IsAssociated : bool
        //IsDeliveryReceiptRequested : bool
        //IsRead : bool
        //IsReadReceiptRequested : bool
        //IsResponseRequested : Option<bool>
        ReceivedByJSON : string
        ReceivedRepresentingJSON : string
        References : string
        ReplyToJSON : string
        SenderJSON : string
        ToRecipientsJSON : string
        
        CategoriesJSON : string
        ServiceAccountId : int
        Tag : int
    }
    override m.ToString() = sprintf "[%A] (%A-%A) %A %A [%A]" m.Id m.InternalId m.ExternalId m.Subject m.From m.ServiceAccountId 
