rem # super commit  

set arg1=%1
set arg2="SC:"
git add --all 
git commit -m   %arg1%

git push origin master 

echo "committet og pushed " 
