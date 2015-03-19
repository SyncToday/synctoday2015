select ISNULL(min(LastSuccessfulDownload), getdate() - 30 ) FROM ServiceAccounts
