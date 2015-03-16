#include <fstream>
#include <vector>

#ifndef __FILENUMBERLOADER_HPP
#define __FILENUMBERLOADER_HPP

/**
 * @brief   The FileNumberLoader class contains methods to load
 * a list number from a persistent file
 * @date    2015-03-16
 * @author  magfernandez
 * @version 1.0
 */
class FileNumberLoader
{
public:

    /**
     * @brief loadFromFile Loads a number list from a file, supposing
     * it contains an integer per line
     * @date    2015-03-16
     * @author  magfernandez
     * @version 1.0
     * @param   aFileName File to read
     * @return  vector of integer read from @param aFileName
     */
    static std::vector<int> loadFromFile( char* aFileName )
    {
        // Create an integer vector to contain the numbers read from the file
        std::vector<int> aVectorNumber;
        std::ifstream aFile( aFileName );
        int a;
        while ( aFile >> a )
        {
            // Read a number and store the result in the vector
            aVectorNumber.push_back( a );
        }
        return aVectorNumber;
    }
};

#endif // __FILENUMBERLOADER_HPP
