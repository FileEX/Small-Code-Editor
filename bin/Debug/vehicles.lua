local d = 5

function changeD(newD)
	if (newD and tonumber(newD)) then
		d = newD
	end
end

changeD(10)

print(d)