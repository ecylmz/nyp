# default dir name
dir = *
CS_FILES  = $(wildcard $(dir)/*.cs)
EXE_FILES = $(patsubst %.cs, %.exe, $(CS_FILES))

.PHONY: clean c

all: exe_build

exe_build: $(EXE_FILES)
	@echo "derlendi"

%.exe: %.cs run
	@gmcs $<

run:
	@echo "derleniyor..."

clean c:
	@rm -f $(EXE_FILES)
	@echo "silindi"
