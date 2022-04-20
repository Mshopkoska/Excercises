using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.PaginationHelper
{
    public class PagnationHelper<T>
    {
        // TODO: Complete this class

        public IList<T> collection { get; set; }
        public int itemsPerPage { get; set; }

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;
            this.itemCount = collection.Count;


            double pgCount = (double)collection.Count / itemsPerPage;
            this.pageCount = (int)Math.Ceiling(pgCount);


        }

        public int itemCount;
        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return itemCount;
            }
        }


        public int pageCount;
        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return pageCount;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex == 0 || pageIndex == 1) return itemsPerPage;
            if (pageIndex > pageCount - 1 || pageIndex < 0) return -1;
            int tmp = itemCount;
            int i = 0;
            int count = itemsPerPage;
            while (i < pageIndex)
            {
                if (tmp >= 0)
                {
                    tmp -= itemsPerPage;
                    i++;
                }
            }
            if (tmp < 0) return -1;
            return tmp;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= itemCount) return -1;
            if (itemIndex == 0) return 0;
            int i = 0;
            int tmp = itemIndex;
            while (tmp >= 0)
            {
                tmp = tmp - itemsPerPage;
                if (tmp <= 0)
                {
                    if (itemIndex % itemsPerPage == 0)
                        i++;

                    break;
                }
                else i++;
            }
            return i;
        }

    }
}

