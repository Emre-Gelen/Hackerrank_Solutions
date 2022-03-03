SELECT hacker.hacker_id, hacker.name as CountRow 
    FROM Hackers hacker
        INNER JOIN Submissions submission on submission.hacker_id = hacker.hacker_id
        INNER JOIN Challenges challenge on challenge.challenge_id = submission.challenge_id
        INNER JOIN Difficulty difficulty on difficulty.difficulty_level = challenge.difficulty_level
    WHERE difficulty.score = submission.score
GROUP BY hacker.hacker_id,hacker.name HAVING COUNT(submission.hacker_id) > 1  
ORDER BY COUNT(hacker.hacker_id) desc,hacker_id