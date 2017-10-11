<#This script is analog of bash example from http://www.learnshell.org/en/Shell_Functions #>
<#examples#>

<#FunctionB#>
function FunctionB { 
    echo "Function B."
}
function FunctionA ($1) {
    echo "$1"
}

<#function takes two parameters and summarize them#>
function Adder ($1, $2) { 
    $1+$2
}

<#FUNCTION CALLS#>
FunctionA("Function A.")
FunctionB
Adder 5 6

<#Exercise ENGLISH_CALC#>
function ENGLISH_CALC ([int]$1, [String]$2, [String]$3){
    if($2 -eq "plus"){
        $1+$2
    }
    elseif($2 -eq "minus"){
        $1-$2
    }
    elseif($2 -eq "times"){
        $1*$2
    }
}

ENGLISH_CALC 3 plus 5