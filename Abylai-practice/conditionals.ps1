<#This script is analog of bash example from http://guide.bash.academy/conditionals/ #>
$RH = Read-Host "Would you like some breakfast? [y/n] " <# read answer from keyboard #>
if($RH -eq 'y'){
    "Here you go, an egg sandwich."
}else{
    "Here, you should at least have a coffee."
}