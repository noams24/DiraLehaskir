"use client";
import { FC } from "react";
import {
  Pagination,
  PaginationContent,
  PaginationEllipsis,
  PaginationItem,
  PaginationLink,
  PaginationNext,
  PaginationPrevious,
} from "@/components/ui/pagination";

interface AppPaginationProps {
  currentPage: number;
  pageCount: number;
  pageChanged: (page: number) => void;
}

const AppPagination: FC<AppPaginationProps> = ({
  currentPage,
  pageCount,
  pageChanged,
}) => {
  const handlePrevPage = () => {
    if (currentPage > 1) {
      pageChanged(currentPage - 1);
    }
  };

  const handleNextPage = () => {
    if (currentPage < pageCount) {
      pageChanged(currentPage + 1);
    }
  };

  return (
    <Pagination>
      <PaginationContent>
        <PaginationItem>
          <PaginationPrevious onClick={() => handlePrevPage()} />
        </PaginationItem>
        <PaginationItem>
          <PaginationLink isActive>{currentPage}</PaginationLink>
        </PaginationItem>
        <PaginationItem>
          <PaginationEllipsis />
        </PaginationItem>
        <PaginationItem>
          <PaginationNext onClick={() => handleNextPage()} />
        </PaginationItem>
      </PaginationContent>
    </Pagination>
  );
};

export default AppPagination;
