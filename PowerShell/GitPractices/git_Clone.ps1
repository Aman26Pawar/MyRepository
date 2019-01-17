echo "enter the url to clone:"
$url_clone = read-host
echo "enter the absolute path to clone at:"
$path_clone = read-host

if($path_clone -ne "")
{
	if(!(Test-path -Path $path_clone))
	{
		write-host "Creating directory"
		New-Item -path $path_clone -ItemType Directory
		write-host "Created directory $path_clone"
		cd $path_clone
		
		if($url_clone -ne "")
		{
			git clone $url_clone
		}
		else
		{
			write-host "Provide URL to clone" -foregroundColor Yellow -background black
		}
	}
	else
	{
		cd $path_clone
		
		if($url_clone -ne "")
		{
			git clone $url_clone
		}
		else
		{
			write-host "Provide URL to clone" -foregroundColor Yellow -background black
		}
	}
}
else		
{
	write-host "Please provide the path to clone at....." -foregroundColor Yellow -background black
}
