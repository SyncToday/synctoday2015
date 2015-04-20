git remote add --track master synctoday https://github.com/SyncToday/synctoday2015.git
git fetch synctoday
git merge synctoday/master
git commit -a -m "fork update"
git push
