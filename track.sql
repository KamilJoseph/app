SELECT artist, title, genre, duration
FROM tracks
INNER JOIN artists ON tracks.artist_id = artists.id
WHERE tracks.release_year = YEAR(NOW()) - 1 -- Or it could be as YEAR(2023/01/01) Etc
AND duration > 0
ORDER BY artist ASC, title ASC;

-- SELECT allows me to specify the column I need for the music tracker: artist, title, genre, duration
-- FROM specify that I have selected track as my table.
-- INNER JOIN allows me to return matching artist from the table track
-- WHERE  releases the track year 
-- Order by artist to return in scending order.