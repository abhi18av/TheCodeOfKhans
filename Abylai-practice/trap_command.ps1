<#This script is analog of bash example from http://www.learnshell.org/en/Bash_trap_command #>
function TrapTest() {
    $s = Read-Host -Prompt 'enter'
    if($s -eq 'enter'){ <#input must be 'enter'#>
        "fine"
    }else {
        trap {"booh!"; break;}
        thiswontwork
    }
} 

TrapTest