#include <iostream>
#include <stdio.h>
#include <thread>
#include <algorithm>
#include "IO/FileNumberLoader.hpp"

int main( int argc, char *argv[] )
{
    // Force program call to have four arguments
    if ( argc!=4 )
    {
        std::cout << "Incorrect argument number. Program terminated\n\n";
    }
    else
    {
        int aThreadNumber = atoi( argv[1] );
        // Load integer values from file
        std::vector<int> anIntegerVector = FileNumberLoader::loadFromFile( argv[2] );
        int anIncrement   = atoi( argv[3] );

        // Show original list in console
        std::cout << "Original:\n";
        for ( std::vector<int>::const_iterator it = anIntegerVector.begin(); it!=anIntegerVector.end(); ++it )
        {
            std::cout << *it << "\n";
        }

        // Create a list of threads, containing the specified number of them
        std::vector<std::thread> aWorkerThreadsList;
        for (int i = 0; i < aThreadNumber; i++)
        {
            aWorkerThreadsList.push_back( std::thread([ &anIntegerVector, anIncrement ]()
            {
                // Each thread will go over the number list, incrementing each value
                // by the specified amount
                for ( unsigned int i = 0; i < anIntegerVector.size(); ++i )
                {
                   anIntegerVector[ i ] = anIntegerVector[ i ] + anIncrement;
                }
            }));
        }

         // Use join to execute each thread on the list one by one
         std::for_each( aWorkerThreadsList.begin(), aWorkerThreadsList.end(), []( std::thread &aThread )
         {
             aThread.join();
         });

         // Print the final result
         std::cout << "\nResult:\n";
         for ( std::vector<int>::const_iterator it = anIntegerVector.begin(); it!=anIntegerVector.end(); ++it )
         {
             std::cout << *it << "\n";
         }

         return 0;
    }
}




